using System.Web;
using System.Web.Mvc;

namespace MyCarpetsAtHomeAPI
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}