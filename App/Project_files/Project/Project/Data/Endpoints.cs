using Newtonsoft.Json;
using Project.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Project.Data
{
    public class Endpoints
    {
        private HttpResponseMessage GET(string url)
        {
            using (System.Net.Http.HttpClient client = new System.Net.Http.HttpClient())
            {
                try
                {
                    var result = client.GetAsync(url);
                    result.Wait();

                    return result.Result;
                }
                catch (AggregateException)
                {
                    return new HttpResponseMessage(System.Net.HttpStatusCode.ServiceUnavailable);
                }
            }
        }
    }
}