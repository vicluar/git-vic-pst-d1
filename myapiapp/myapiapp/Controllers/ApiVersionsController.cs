using Microsoft.AspNetCore.Mvc;
using myapiapp.Models;

namespace myapiapp.Controllers;

[ApiController]
public class ApiVersionsController : ControllerBase
{
    [HttpGet("/")]
    public ApiVersionsResponse GetApiVersions()
    {
        return new ApiVersionsResponse
        {
            Versions = new List<VersionInfo>
            {
                new VersionInfo
                {
                    Status = "CURRENT",
                    Updated = "2011-01-21T11:33:21Z",
                    Id = "v2.0",
                    Links = new List<VersionLink>
                    {
                        new VersionLink
                        {
                            Href = "http://127.0.0.1:8774/v2/",
                            Rel = "self"
                        }
                    }
                },
                new VersionInfo
                {
                    Status = "EXPERIMENTAL",
                    Updated = "2013-07-23T11:33:21Z",
                    Id = "v3.0",
                    Links = new List<VersionLink>
                    {
                        new VersionLink
                        {
                            Href = "http://127.0.0.1:8774/v3/",
                            Rel = "self"
                        }
                    }
                }
            }
        };
    }
}
