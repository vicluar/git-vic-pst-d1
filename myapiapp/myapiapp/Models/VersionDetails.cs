namespace myapiapp.Models;

using System.Text.Json.Serialization;

public class VersionDetails
{
    public string? Status { get; set; }
    public string? Updated { get; set; }
    
    [JsonPropertyName("media-types")]
    public List<MediaType>? MediaTypes { get; set; }
    
    public string? Id { get; set; }
    public List<VersionLink>? Links { get; set; }
}
