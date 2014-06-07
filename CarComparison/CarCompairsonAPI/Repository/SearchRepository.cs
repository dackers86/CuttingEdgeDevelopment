using CarCompairsonAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using System.Net;

namespace CarCompairsonAPI.Repository
{
    public class SearchRepository : ISearchRepository
    {
        private CarComparisonContext context;

        public SearchRepository()
        {
            this.context = new CarComparisonContext();
        }

        public HttpResponseMessage GetSearchQuery()
        {
            var result = new SearchQuery 
            { 
                count = 20,
                Manufacturer = context.Manufacturers.ToList(),
                Model = context.Models.ToList() 
            };

            var jsonResult = JsonConvert.SerializeObject(result, new JsonSerializerSettings
            {
                PreserveReferencesHandling = PreserveReferencesHandling.None,
                ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
                 
            });

            var response = new HttpResponseMessage { StatusCode = HttpStatusCode.OK };
            response.Content = new StringContent(jsonResult, Encoding.UTF8, "application/json");
            return response;
        }
    }
}