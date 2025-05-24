public class CloudStorageConfig
{
    /// <summary>
    /// The provider name.
    /// </summary>
    public string? Provider { get; set; }

    /// <summary>
    /// The storage bucket, container, or equivalent.
    /// Required
    /// </summary>
    public string BucketOrContainerName { get; set; } = default!;

    /// <summary>
    /// AWS Access Key, Azure connection string, or similar.
    /// </summary>
    public string? AccessKey { get; set; }

    /// <summary>
    /// AWS Secret, Azure secondary key, etc.
    /// </summary>
    public string? Secret { get; set; }

    /// <summary>
    /// Custom endpoint override.
    /// </summary>
    public string? EndpointUrl { get; set; }
}