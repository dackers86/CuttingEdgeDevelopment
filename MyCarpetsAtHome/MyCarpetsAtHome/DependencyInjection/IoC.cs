using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StructureMap;
using MyCarpetsAtHome.MyCarpetsService;

namespace MyCarpetsAtHome.DependencyInjection
{
    public static class IoC
    {
        public static void PreStart()
        {
            ObjectFactory.Configure(x =>
            {
                x.Scan(scan =>
                {
                    scan.TheCallingAssembly();
                    scan.WithDefaultConventions();
                    scan.AssembliesFromApplicationBaseDirectory();
                });

                x.For<IService>().Use(new MyCarpetsService.ServiceClient("Default"));
            });

            //ObjectFactory.Initialize(x => x.AddRegistry(typeof(IServiceChannel()));



        }
    }
}