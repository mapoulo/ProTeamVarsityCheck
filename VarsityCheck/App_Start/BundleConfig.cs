using System.Web;
using System.Web.Optimization;

namespace VarsityCheck
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery.js"));

            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                        "~/Scripts/isotope.min.js",
                        "~/Scripts/hoverdir.js",
                        "~/Scripts/unveil-effects.js",
                        "~/Scripts/owl-carousel.js",
                        "~/Scripts/jetmenu.js",
                        "~/Scripts/animate-enhanced.min.js",
                        "~/Scripts/jigowatt.js",
                        "~/Scripts/easypiechart.min.js",
                        "~/Scripts/main.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap.css",
                      "~/Content/font-awesome.min.css",
                      "~/Content/prettyphoto.css",
                      "~/Content/hoverex-all.css",
                      "~/Content/jetmenu.css",
                      "~/Content/owl-carousel.css",
                      "~/Content/style.css",
                      "~/Content/bbpress.css",
                      "~/Content/blue.css"));

        }
    }
}
