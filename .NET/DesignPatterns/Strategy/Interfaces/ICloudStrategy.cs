public interface ICloudStrategy
{
    Task<UploadCloudBlobResult> UploadBlobAsync(string fileName, byte[] data);
}