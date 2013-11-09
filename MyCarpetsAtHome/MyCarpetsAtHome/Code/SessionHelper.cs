using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.SessionState;
using MyCarpetsAtHome.MyCarpetsService;
using StructureMap;

namespace MyCarpetsAtHome.Code
{
    public static class SessionHelper
    {

        #region private variables

        private static IService MyCarpetsService;
        private static List<Lookup> lookups;

        #endregion

        private static void LoadService()
        {
            MyCarpetsService = ObjectFactory.GetInstance<IService>();
        }


        public static void InitialiseLookups()
        {
            LoadService();
            LoadLookups();
        }


        private static List<Lookup> LoadLookups()
        {
            if (GetSession("Lookups") == null)
            {
                SetSession("Lookups", MyCarpetsService.ReturnAllLookups().ToList());
            }
            return (List<Lookup>)GetSession("Lookups");
        }

        private static void SetSession(string name, object o)
        {
            HttpContext.Current.Session[name] = o;
        }

        private static object GetSession(string name)
        {
            return HttpContext.Current.Session[name];
        }

    }
}