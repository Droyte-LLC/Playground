public class AzureCloudStrategy : ICloudStrategy
{
  private readonly CloudStorageConfig _config;

  public AzureCloudStrategy(CloudStorageConfig config)
  {
    _config = config;
  }
    public async Task<UploadCloudBlobResult> UploadBlobAsync(string blobName, byte[] data)
    {
        Console.WriteLine($"Uploading {blobName} to Azure...");

        // Simulate API logic
        // MOCK
        // In a real-world scenario, you would use the Azure SDK to upload blobs.
        return await Task.FromResult(new UploadCloudBlobResult
        {
            BlobName = "TheNameOfTheBlob",
            BlobUriPath = "ExamplePath:https://{storage-account-name}.blob.core.windows.net/{container-name}/{blob-name}"
        });
    }
}