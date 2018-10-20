using System.Web;
using System.Web.Optimization;

namespace WebApplication
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",                      
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",                      

                      "~/Content/site.css"));

            // vendor/bootstrap/js
            bundles.Add(new ScriptBundle("~/Content/vendor/bootstrap/js").Include(

                      "~/Content/vendor/bootstrap/bootstrap.bundle.js",
                      "~/Content/vendor/bootstrap/bootstrap.bundle.js.map",
                      "~/Content/vendor/bootstrap/bootstrap.bundle.min.js",
                      "~/Content/vendor/bootstrap/bootstrap.bundle.min.js.map",
                      "~/Content/vendor/bootstrap/bootstrap.js",
                      "~/Content/vendor/bootstrap/bootstrap.js.map",
                      "~/Content/vendor/bootstrap/bootstrap.min.js",
                      "~/Content/vendor/bootstrap/bootstrap.min.js.map"));                            

            // vendor/jquery/
            bundles.Add(new ScriptBundle("~/Content/vendor/jquery").Include(
                      
                      "~/Content/vendor/jquery/jquery.js",
                      "~/Content/vendor/jquery/jquery.min.js",
                      "~/Content/vendor/jquery/jquery.min.map",
                      "~/Content/vendor/jquery/jquery.slim.js",
                      "~/Content/vendor/jquery/jquery.slim.min.js",
                      "~/Content/vendor/jquery/jquery.slim.min.map"

                ));

            // vendor/bootstrap/css
            bundles.Add(new StyleBundle("~/Content/vendor/bootstrap/css").Include(                   

                   "~/Content/vendor/bootstrap/css/bootstrap.css",
                   "~/Content/vendor/bootstrap/css/bootstrap.css.map",
                   "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                   "~/Content/vendor/bootstrap/css/bootstrap.min.css.map",
                   "~/Content/vendor/bootstrap/css/bootstrap-grid.css",
                   "~/Content/vendor/bootstrap/css/bootstrap-grid.min.css",
                   "~/Content/vendor/bootstrap/css/bootstrap-reboot.css",
                   "~/Content/vendor/bootstrap/css/bootstrap-reboot.min.css"));

            // css           
            bundles.Add(new StyleBundle("~/Content/css").Include(
                   "~/Content/css/magazine.css"));
        }
    }
}
