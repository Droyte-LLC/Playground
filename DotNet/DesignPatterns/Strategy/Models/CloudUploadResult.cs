public class UploadCloudBlobResult
{
    /// <summary>
    /// Entity Tag returned by cloud storage provider.
    /// </summary>
    public string ETag { get; set; } = default!;

    /// <summary>
    /// Version Id of the uploaded blob, if versioning is enabled.
    /// </summary>
    public string VersionId { get; set; } = default!;

    /// <summary>
    /// Last Modified timestamp of the blob.
    /// </summary>
    public DateTimeOffset LastModified { get; set; } = default!;
    
    /// <summary>
    /// The name of the blob in the cloud storage system.
    /// </summary>
    public string BlobName { get; set; } = default!;

    /// <summary>
  /// The full path or URI to the stored blob in the cloud storage system.
  /// </summary>
  public string BlobUriPath { get; set; } = default!;

    /// <summary>
    /// Name of the storage provider.
    /// </summary>
    public string Provider { get; set; } = default!;

    /// <summary>
    /// Metadata or additional data returned by the provider.
    /// </summary>
    public Dictionary<string, string> Metadata { get; set; } = default!;
}
