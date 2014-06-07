using CarCompairsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace CarComparison.Helpers
{
    public class Helper : IHelper
    {
        public object ExecuteHTTPClient<T>(string method, string source)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            
            var serializerSettings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects };


            var json  = client.GetAsync(source).Result.Content.ToString();

            return JsonConvert.DeserializeObject<T>(json, serializerSettings);

            //return client.GetAsync(source).Result.Content.ReadAsAsync<T>().Result;
        }
    }
}