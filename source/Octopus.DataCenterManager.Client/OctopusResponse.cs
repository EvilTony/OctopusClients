using System.Net;

namespace Octopus.DataCenterManager.Client
{
    /// <summary>
    /// Describes a response from the Octopus server.
    /// </summary>
    /// <typeparam name="TResponseResource">The resource type associated with the response.</typeparam>
    public class OctopusResponse<TResponseResource> : OctopusResponse
    {
        public OctopusResponse(OctopusRequest request, HttpStatusCode statusCode, string location, TResponseResource responseResource) : base(request, statusCode, location, responseResource)
        {
        }

        public new TResponseResource ResponseResource => (TResponseResource)base.ResponseResource;
    }

    /// <summary>
    /// Describes a response from the Octopus server.
    /// </summary>
    public class OctopusResponse
    {
        public OctopusResponse(OctopusRequest request, HttpStatusCode statusCode, string location, object responseResource)
        {
            Request = request;
            StatusCode = statusCode;
            Location = location;
            ResponseResource = responseResource;
        }

        public OctopusRequest Request { get; }

        public HttpStatusCode StatusCode { get; }

        public string Location { get; }

        public object ResponseResource { get; }
    }
}