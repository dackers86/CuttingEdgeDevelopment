using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarCompairsonAPI;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using System.Web;
using System.IO;
using Newtonsoft.Json.Linq;

namespace VisualUnitTesting
{
    public class Class1
    {
        static void Main(string[] args)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost/");

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            var serializerSettings = new JsonSerializerSettings { PreserveReferencesHandling = PreserveReferencesHandling.Objects };

            var json = string.Empty;
            using (var reader = new StreamReader(client.GetAsync("CarCompairsonAPI/API/Search").Result.Content.ReadAsStreamAsync().Result))
            {
                var res = JsonConvert.DeserializeObject<CarCompairsonAPI.Models.Model>(reader.ReadToEnd(), serializerSettings);
            }

            var result1  = JsonConvert.DeserializeObject<List<CarCompairsonAPI.Models.Model>>(json, serializerSettings);


            var context = new CarCompairsonAPI.Repository.CarRepository();
            CarCompairsonAPI.Controllers.CarController test = new CarCompairsonAPI.Controllers.CarController(context);
            var result = test.Get();
        }
    }
}
