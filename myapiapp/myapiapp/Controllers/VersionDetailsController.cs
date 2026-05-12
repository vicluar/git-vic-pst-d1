using Microsoft.AspNetCore.Mvc;
using myapiapp.Models;

namespace myapiapp.Controllers;

[ApiController]
public class VersionDetailsController : ControllerBase
{
    [HttpGet("/v2")]
    public VersionDetailsResponse GetVersionDetails()
    {
        return new VersionDetailsResponse
        {
            Version = new VersionDetails
            {
                Status = "CURRENT",
                Updated = "2011-01-21T11:33:21Z",
                MediaTypes = new List<MediaType>
                {
                    new MediaType
                    {
                        Base = "application/xml",
                        Type = "application/vnd.openstack.compute+xml;version=2"
                    },
                    new MediaType
                    {
                        Base = "application/json",
                        Type = "application/vnd.openstack.compute+json;version=2"
                    }
                },
                Id = "v2.0",
                Links = new List<VersionLink>
                {
                    new VersionLink
                    {
                        Href = "http://127.0.0.1:8774/v2/",
                        Rel = "self"
                    },
                    new VersionLink
                    {
                        Href = "http://docs.openstack.org/api/openstack-compute/2/os-compute-devguide-2.pdf",
                        Type = "application/pdf",
                        Rel = "describedby"
                    },
                    new VersionLink
                    {
                        Href = "http://docs.openstack.org/api/openstack-compute/2/wadl/os-compute-2.wadl",
                        Type = "application/vnd.sun.wadl+xml",
                        Rel = "describedby"
                    },
                    new VersionLink
                    {
                        Href = "http://docs.openstack.org/api/openstack-compute/2/wadl/os-compute-2.wadl",
                        Type = "application/vnd.sun.wadl+xml",
                        Rel = "describedby"
                    }
                }
            }
        };
    }
}
