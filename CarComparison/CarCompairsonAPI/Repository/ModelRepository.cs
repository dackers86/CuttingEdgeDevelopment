using CarCompairsonAPI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Data.Entity;

namespace CarCompairsonAPI.Repository
{
    public class ModelRepository: IModelRepository
    {
        private CarComparisonContext context;

        public ModelRepository()
        {
            this.context = new CarComparisonContext();
        }

        public ModelRepository(CarComparisonContext context)
        {
            this.context = context;
        }

        public HttpResponseMessage GetModelsBySearchQuery(SearchQuery searchQuery)
        {
            if (searchQuery == null)
                searchQuery = new SearchQuery();

            var maxCount = 20;

            var result = context.Models
                          .Include(m => m.Manufacturer)
                          .OrderBy(m => m.NoughtToSixty)
                          .Take(searchQuery.count == 0 ? maxCount : searchQuery.count)
                          .ToList();

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