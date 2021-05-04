//using Google.Apis.Auth.OAuth2;
//using Google.Apis.Services;
//using Google.Apis.Sheets.v4;
//using Google.Apis.Sheets.v4.Data;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection;
//using System.Text;
//using System.Threading.Tasks;

//namespace CoreBackpack.Services
//{
//    public interface IGoogleServices
//    {

//    }
    
//    public class GoogleServices : IGoogleServices
//    {
//        public async Task<IList<IList<object>>> ReadRawSheet(string spreadsheetId, string range)
//        {
//            string applicationName = "CoreBackpack";

//            var googleJson = new GoogleJson();
//            var authenticationJson = JsonConvert.SerializeObject(googleJson);

//            var credential = GoogleCredential.FromJson(authenticationJson)
//                .CreateScoped(new[] { SheetsService.Scope.SpreadsheetsReadonly });

//            // Create Google Sheets API service.
//            var service = new SheetsService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = applicationName
//            });

//            // Define request parameters.
//            SpreadsheetsResource.ValuesResource.GetRequest request =
//                    service.Spreadsheets.Values.Get(spreadsheetId, range);

//            ValueRange response = await request.ExecuteAsync();

//            return response.Values;
//        }

//        public async Task<IList<T>> ReadSheet<T>(string spreadsheetId, string range)
//        {
//            string applicationName = "CoreBackpack";

//            var googleJson = new GoogleJson();
//            var authenticationJson = JsonConvert.SerializeObject(googleJson);

//            var credential = GoogleCredential.FromJson(authenticationJson)
//                .CreateScoped(new[] { SheetsService.Scope.SpreadsheetsReadonly });

//            // Create Google Sheets API service.
//            var service = new SheetsService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = applicationName
//            });

//            // Define request parameters.
//            SpreadsheetsResource.ValuesResource.GetRequest request =
//                    service.Spreadsheets.Values.Get(spreadsheetId, range);

//            ValueRange response = await request.ExecuteAsync();

//            var instance = Activator.CreateInstance(typeof(T));
//            var propertyInfos = instance.GetType().GetProperties();

//            var list = new List<T>();

//            int row = 0;
//            foreach (var item in response.Values)
//            {
//                var newObj = Activator.CreateInstance(typeof(T));
//                int column = 0;
//                foreach (PropertyInfo propertyInfo in propertyInfos)
//                {
//                    try
//                    {
//                        var val = response.Values[row][column];
//                        propertyInfo.SetValue(newObj, val);
//                    }
//                    catch (Exception) { }

//                    column++;
//                }
//                list.Add((T)newObj);

//                row++;
//            }

//            return list;
//        }

//        public async Task ClearSheet(string spreadsheetId, string range = "")
//        {
//            string applicationName = "CoreBackpack";

//            var googleJson = new GoogleJson();
//            var authenticationJson = JsonConvert.SerializeObject(googleJson);

//            var credential = GoogleCredential.FromJson(authenticationJson)
//                .CreateScoped(new[] { SheetsService.Scope.Spreadsheets });

//            // Create Google Sheets API service.
//            var service = new SheetsService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = applicationName
//            });


//            ClearValuesRequest requestBody = new ClearValuesRequest();
//            SpreadsheetsResource.ValuesResource.ClearRequest request = service.Spreadsheets.Values.Clear(requestBody, spreadsheetId, range);

//            await request.ExecuteAsync();
//        }

//        public async Task WriteErrorSheet(string spreadsheetId, List<ErrorSheet> errorData, string range = "")
//        {
//            string applicationName = "CoreBackpack";

//            var googleJson = new GoogleJson();
//            var authenticationJson = JsonConvert.SerializeObject(googleJson);

//            var credential = GoogleCredential.FromJson(authenticationJson)
//                .CreateScoped(new[] { SheetsService.Scope.Spreadsheets });

//            // Create Google Sheets API service.
//            var service = new SheetsService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = applicationName
//            });

//            // The new values to apply to the spreadsheet.
//            var Rows = new List<IList<object>>();

//            int row = 0;
//            foreach (var data in errorData)
//            {
//                var errorRow = new List<Object>();
//                errorRow.Add(data.ProductName);
//                errorRow.Add(data.Errors);

//                Rows.Add(errorRow);
//            }

//            List<ValueRange> updateDataRange = new List<ValueRange>();

//            var dataValueRange = new ValueRange();
//            dataValueRange.Range = range;
//            dataValueRange.Values = Rows;
//            updateDataRange.Add(dataValueRange);


//            BatchUpdateValuesRequest requestBody = new BatchUpdateValuesRequest();
//            requestBody.ValueInputOption = "USER_ENTERED";
//            requestBody.Data = updateDataRange;

//            var updateService = service.Spreadsheets.Values.BatchUpdate(requestBody, spreadsheetId);

//            await updateService.ExecuteAsync();
//        }

//        public async Task CreateSheet(string name)
//        {
//            string applicationName = "CoreBackpack";

//            var googleJson = new GoogleJson();
//            var authenticationJson = JsonConvert.SerializeObject(googleJson);

//            var credential = GoogleCredential.FromJson(authenticationJson)
//                .CreateScoped(new[] { SheetsService.Scope.Spreadsheets });

//            // Create Google Sheets API service.
//            var service = new SheetsService(new BaseClientService.Initializer()
//            {
//                HttpClientInitializer = credential,
//                ApplicationName = applicationName
//            });


//            var myNewSheet = new Spreadsheet();
//            myNewSheet.Properties = new SpreadsheetProperties();
//            myNewSheet.Properties.Title = name;


//            var newSheet = service.Spreadsheets.Create(myNewSheet);


//            await newSheet.ExecuteAsync();
//        }
//    }
//}
