using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CoreBackpack.Azure
{
    public class BlobStorage
    {
        public async Task DeleteBlob(string connectionString, string containerName, string fileName)
        {
            try
            {
                CloudStorageAccount storageAccount = null;
                // Check whether the connection string can be parsed.

                if (CloudStorageAccount.TryParse(connectionString, out storageAccount))
                {
                    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

                    CloudBlobContainer cloudBlobContainer = null;

                    cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);

                    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);
                    
                    await cloudBlockBlob.DeleteIfExistsAsync();
                }
                else
                {
                    // Otherwise, let the user know that they need to define the environment variable.
                    Console.WriteLine(
                        "A connection string has not been defined in the system environment variables. " +
                        "Add a environment variable named 'storageconnectionstring' with your storage " +
                        "connection string as a value.");
                    Console.WriteLine("Press any key to exit the sample application.");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static string GetBlob(string connectionString, string containerName, string fileName)
        {
            string url = "";
            CloudStorageAccount storageAccount = null;

            // Check whether the connection string can be parsed.
            if (CloudStorageAccount.TryParse(connectionString, out storageAccount))
            {
                CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

                CloudBlobContainer cloudBlobContainer = null;

                cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);

                var blob = cloudBlobContainer.GetBlobReference(fileName);

                url = blob.Uri.AbsoluteUri;
            }

            return url;
        }

        public static async Task<string> UploadBlob(string connectionString, Stream file, string containerName, string fileName)
        {
            try
            {
                CloudStorageAccount storageAccount = null;

                if (CloudStorageAccount.TryParse(connectionString, out storageAccount))
                {
                    CloudBlobClient cloudBlobClient = storageAccount.CreateCloudBlobClient();

                    CloudBlobContainer cloudBlobContainer = null;

                    cloudBlobContainer = cloudBlobClient.GetContainerReference(containerName);

                    CloudBlockBlob cloudBlockBlob = cloudBlobContainer.GetBlockBlobReference(fileName);

                    await cloudBlockBlob.UploadFromStreamAsync(file);

                    return cloudBlockBlob.Uri.AbsoluteUri;
                }
                else
                {
                    throw new Exception("A connection string has not been defined in the system environment variables.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}