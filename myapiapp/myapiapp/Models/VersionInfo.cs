namespace myapiapp.Models;

public class VersionInfo
{
    public string? Status { get; set; }
    public string? Updated { get; set; }
    public string? Id { get; set; }
    public List<VersionLink>? Links { get; set; }
}
