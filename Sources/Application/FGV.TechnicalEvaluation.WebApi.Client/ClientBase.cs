using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FGV.TechnicalEvaluation.WebApi.Client
{
    public abstract class ClientBase : IDisposable
    {
        protected readonly HttpClient Client;

        protected ClientBase(string baseUri) : this(baseUri, null)
        {
        }

        protected ClientBase(string baseUri, WebRequestHandler handler) : this(handler)
        {
            Client.BaseAddress = new Uri(!baseUri.EndsWith("/") ? baseUri + "/" : baseUri);
        }

        protected ClientBase(WebRequestHandler handler)
        {
            Client = handler != null ? new HttpClient(handler) : new HttpClient();
        }

        public virtual void Dispose()
        {
            Client.Dispose();
        }
    }
}
