public class AmazonCloudStrategy : ICloudStrategy
{
    private readonly CloudStorageConfig _config;

    public AmazonCloudStrategy(CloudStorageConfig config)
    {
        _config = config;
    }
    public async Task<UploadCloudBlobResult> UploadBlobAsync(string blobName, byte[] data)
    {
        Console.WriteLine($"Uploading {blobName} to Amazon S3...");

        // Simulate API logic
        // MOCK
        // In a real-world scenario, you would use the AWS SDK to upload blobs to S3.
        return await Task.FromResult(new UploadCloudBlobResult
        {
            BlobName = "TheNameOfTheBlob",
            BlobUriPath = "ExamplePath:https://${_config.BucketName}.s3.amazonaws.com/${blobName}"
        });
    }
}