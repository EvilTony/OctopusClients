using System;
using System.Net;
using Octopus.DataCenterManager.Client.Util;

namespace Octopus.DataCenterManager.Client
{
    public class OctopusDataCenterManagerEndpoint
    {
        public OctopusDataCenterManagerEndpoint(string serverAddress, string apiKey)
        {
            Timeout = TimeSpan.FromSeconds(30);
            ServerAddress = serverAddress;
            ApiKey = apiKey;
            LinkResolver = new DefaultLinkResolver(new Uri(serverAddress));
        }

        public string ServerAddress { get; }
        public string ApiKey { get; }

        public TimeSpan Timeout { get; set; }
        public IWebProxy Proxy { get; set; }
        public ILinkResolver LinkResolver { get; }
    }
}