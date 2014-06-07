using CarCompairsonAPI.DependencyInjection;
using CarCompairsonAPI.Repository;
using CarComparisonAPI.Formatters;
using Microsoft.Practices.Unity;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace CarCompairsonAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { controller = "Car", id = RouteParameter.Optional }
            );
        }

        public static void RegisterApis(HttpConfiguration config)
        {

            /*** Serialiser added to allow circular references ***/
            //GlobalConfiguration.Configuration.Formatters.Clear();
            //GlobalConfiguration.Configuration.Formatters.Insert(0, new JsonNetFormatter(new JsonSerializerSettings
            //                                         {
            //                                             PreserveReferencesHandling = PreserveReferencesHandling.None,
            //                                             ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            //                                         }));
        }
    }
}
