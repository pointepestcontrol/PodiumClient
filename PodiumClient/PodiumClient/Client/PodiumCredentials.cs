using Microsoft.Rest;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Podium.Client
{
    public class PodiumCredentials : ServiceClientCredentials
    {
        private string APIKey { get; set; }
        public PodiumCredentials(string key)
        {
            APIKey = key;
        }

        public override Task ProcessHttpRequestAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Add("Authorization", APIKey);
            return base.ProcessHttpRequestAsync(request, cancellationToken);
        }
    }
}
