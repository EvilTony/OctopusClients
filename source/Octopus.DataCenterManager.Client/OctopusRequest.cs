using System;

namespace Octopus.DataCenterManager.Client
{
    /// <summary>
    /// Describes a request made to the Octopus server by the client.
    /// </summary>
    public class OctopusRequest
    {
        public OctopusRequest(string method, Uri uri, object requestResource = null)
        {
            Method = method;
            Uri = uri;
            RequestResource = requestResource;
        }

        public string Method { get; }
        public Uri Uri { get; }
        public object RequestResource { get; }
    }
}