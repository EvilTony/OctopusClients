using System;
using System.Net;

namespace Octopus.DataCenterManager.Client.Util
{
    public class ClientProxy : IWebProxy
    {
        public ClientProxy(string address, string username, string password)
        {
            ProxyUri = new Uri(address);
            Credentials = username == null && password == null
                ? CredentialCache.DefaultCredentials
                : new NetworkCredential(username, password);
        }

        public Uri ProxyUri { get; protected set; }

        public ICredentials Credentials { get; set; }

        public Uri GetProxy(Uri destination) => ProxyUri;

        public bool IsBypassed(Uri host) => false;
    }
}