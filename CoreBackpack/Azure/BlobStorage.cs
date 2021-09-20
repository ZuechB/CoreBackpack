using Azure;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CoreBackpack.Azure
{
    public interface IBlobStorage
    {
        Task<BlobContentInfo> UploadBlob(string connectionString, string containerName, string blobName, Stream stream, bool overWrite = false, string newCacheControl = null, string contentType = null);
        Task<BlobContentInfo> UploadBlob(string connectionString, string containerName, string blobName, string filePath, bool overWrite = false, string newCacheControl = null, string contentType = null);
        Task<bool> DeleteBlob(string connectionString, string containerName, string blobName);
        Task<Response> DownloadPrivateBlob(string connectionString, string containerName, string downloadFromPath, string downloadToPath);
        Task<Response> DownloadPrivateBlob(string connectionString, string containerName, string downloadFromPath, Stream downloadToPath);
        Task<Response> DownloadPublicBlob(string downloadFromPath, string downloadToPath);
        Task<Response> DownloadPublicBlob(string downloadFromPath, Stream downloadToStream);

        Task UpdateAllBlobsProperties(string connectionString, string containerName, string newCacheControl = "max-age=31536000", string contentType = "image/*", Action<int, string> CurrentBlobUpdated = null);
    }

    public class BlobStorage : IBlobStorage
    {
        public async Task<BlobContentInfo> UploadBlob(string connectionString, string containerName, string blobName, Stream stream, bool overWrite = false, string newCacheControl = null, string contentType = null)
        {
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            // Get a reference to a blob named "sample-file" in a container named "sample-container"
            BlobClient blob = container.GetBlobClient(blobName);

            // Upload local file
            var responseBlob = await blob.UploadAsync(stream, overWrite);

            await SetBlobPropertiesAsync(blob, newCacheControl, contentType);

            return responseBlob;
        }

        public async Task<BlobContentInfo> UploadBlob(string connectionString, string containerName, string blobName, string filePath, bool overWrite = false, string newCacheControl = null, string contentType = null)
        {
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);
            
            // Get a reference to a blob named "sample-file" in a container named "sample-container"
            BlobClient blob = container.GetBlobClient(blobName);

            // Upload local file
            var responseBlob = await blob.UploadAsync(filePath, overWrite);

            await SetBlobPropertiesAsync(blob, newCacheControl, contentType);

            return responseBlob;
        }

        public async Task<bool> DeleteBlob(string connectionString, string containerName, string blobName)
        {
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            // Get a reference to a blob named "sample-file" in a container named "sample-container"
            BlobClient blob = container.GetBlobClient(blobName);

            // Upload local file
            return await blob.DeleteIfExistsAsync();
        }

        public async Task<Response> DownloadPrivateBlob(string connectionString, string containerName, string blobName, string downloadToPath)
        {
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            // Get a reference to a blob named "sample-file" in a container named "sample-container"
            BlobClient blob = container.GetBlobClient(blobName);

            // Upload local file
            return await blob.DownloadToAsync(downloadToPath);
        }

        public async Task<Response> DownloadPrivateBlob(string connectionString, string containerName, string blobName, Stream downloadToPath)
        {
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            // Get a reference to a blob named "sample-file" in a container named "sample-container"
            BlobClient blob = container.GetBlobClient(blobName);

            // Upload local file
            return await blob.DownloadToAsync(downloadToPath);
        }

        public async Task<Response> DownloadPublicBlob(string downloadFromPath, string downloadToPath)
        {
            return await new BlobClient(new Uri(downloadFromPath)).DownloadToAsync(downloadToPath);
        }

        public async Task<Response> DownloadPublicBlob(string downloadFromPath, Stream downloadToStream)
        {
            return await new BlobClient(new Uri(downloadFromPath)).DownloadToAsync(downloadToStream);
        }

        public async Task UpdateAllBlobsProperties(string connectionString, string containerName, string newCacheControl = "max-age=31536000", string contentType = "image/*", Action<int, string> CurrentBlobUpdated = null)
        {
            BlobContainerClient container = new BlobContainerClient(connectionString, containerName);

            int index = 1;
            var blobs = container.GetBlobs();
            foreach (var blob in blobs)
            {
                BlobClient blobClient = container.GetBlobClient(blob.Name);
                await SetBlobPropertiesAsync(blobClient, newCacheControl, contentType);

                if (CurrentBlobUpdated != null)
                {
                    CurrentBlobUpdated(index, blob.Name);
                }

                index++;
            }
        }

        public async Task SetBlobPropertiesAsync(BlobClient blob, string newCacheControl = null, string newContentType = null)
        {
            var properties = await blob.GetPropertiesAsync();

            BlobHttpHeaders headers = new BlobHttpHeaders
            {
                // Populate remaining headers with 
                // the pre-existing properties
                ContentType = properties.Value.ContentType,
                ContentLanguage = properties.Value.ContentLanguage,
                CacheControl = properties.Value.CacheControl,
                ContentDisposition = properties.Value.ContentDisposition,
                ContentEncoding = properties.Value.ContentEncoding,
                ContentHash = properties.Value.ContentHash
            };

            if (!String.IsNullOrWhiteSpace(newCacheControl))
            {
                headers.CacheControl = newCacheControl;
            }

            if (!String.IsNullOrWhiteSpace(newContentType))
            {
                headers.ContentType = newContentType;
            }

            // Set the blob's properties.
            await blob.SetHttpHeadersAsync(headers);
        }
    }
}
