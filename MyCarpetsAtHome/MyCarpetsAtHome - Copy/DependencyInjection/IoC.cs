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
        public static IContainer Initialize()
        {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                            {
                                scan.TheCallingAssembly();
                                scan.WithDefaultConventions();
                            });
                            x.For<IService>().Use<IServiceChannel>();
                        });

            return ObjectFactory.Container;
        }
    }
}