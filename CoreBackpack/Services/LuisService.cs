using CoreBackpack.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace CoreBackpack.Services
{
    public interface ILuisService
    {
        Task<List<LuisService.LuisResponseModel>> Ask(string message, string luisAppId, string endpointKey, bool spellCheck = false, bool verbose = false, bool staging = false);
    }

    public class LuisService : ILuisService
    {
        public async Task<List<LuisResponseModel>> Ask(string message, string luisAppId, string endpointKey, bool spellCheck = false, bool verbose = false, bool staging = false)
        {
            var responses = new List<LuisResponseModel>();

            var messages = ParseMessages(message);

            foreach (var newMessage in messages)
            {
                var client = new HttpClient();
                var queryString = HttpUtility.ParseQueryString(string.Empty);

                // The request header contains your subscription key
                client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", endpointKey);

                // The "q" parameter contains the utterance to send to LUIS
                queryString["q"] = newMessage;

                // These optional request parameters are set to their default values
                queryString["timezoneOffset"] = "0";
                queryString["verbose"] = verbose.ToString();
                queryString["spellCheck"] = spellCheck.ToString();
                queryString["staging"] = staging.ToString();

                var endpointUri = "https://westus.api.cognitive.microsoft.com/luis/v2.0/apps/" + luisAppId + "?" + queryString;
                var response = await client.GetAsync(endpointUri);

                var strResponseContent = await response.Content.ReadAsStringAsync();
                var luisResponse = JsonConvert.DeserializeObject<LuisResponse>(strResponseContent);
                if (luisResponse != null)
                {
                    responses.Add(ParseResponse(luisResponse));
                }
            }

            return responses;
        }

        private LuisResponseModel ParseResponse(LuisResponse luisResponse)
        {
            var model = new LuisResponseModel();
            foreach (var entity in luisResponse.entities)
            {
                if (!String.IsNullOrWhiteSpace(entity.role))
                {
                    model.Name = entity.role;
                }

                if (entity.resolution != null)
                {
                    model.Value = entity.resolution.value;
                }
            }
            return model;
        }

        private string[] ParseMessages(string message)
        {
            return message.Split("and");
        }

        public class LuisResponseModel
        {
            public string Name { get; set; }
            public string Value { get; set; }
        }
    }
}