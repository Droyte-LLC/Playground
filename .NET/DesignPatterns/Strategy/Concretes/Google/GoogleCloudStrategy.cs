public class GoogleCloudStrategy : ICloudStrategy
{
    private readonly CloudStorageConfig _config;

    public GoogleCloudStrategy(CloudStorageConfig config)
    {
        _config = config;
    }
    public async Task<UploadCloudBlobResult> UploadBlobAsync(string blobName, byte[] data)
    {
        Console.WriteLine($"Uploading {blobName} to Google...");

        // Simulate API logic
        // MOCK
        // In a real-world scenario, you would use the Google SDK to upload blobs.
        return await Task.FromResult(new UploadCloudBlobResult
        {
            BlobName = "TheNameOfTheBlob",
            BlobUriPath = "ExamplePath:https://storage.googleapis.com/${_config.BucketName}/${blobName}"
        });
    }
}