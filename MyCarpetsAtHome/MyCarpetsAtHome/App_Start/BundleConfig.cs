using System.Web;
using System.Web.Optimization;

namespace MyCarpetsAtHome
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.jcarousel.min.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/jquery.jquery.jcoverflip.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryunobtrusive").Include(
                        "~/Scripts/jquery.unobtrusive-ajax.min.js*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/custom").Include(
                        "~/Scripts/MyCarpetsAtHome.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                        "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/css/MyCarpetsAtHome.css",
                                                                 "~/Content/css/jcarousel.simple.css",
                                                                 "~/Content/css/bootstrap.css"));
        }
    }
}