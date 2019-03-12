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
                        "~/Scripts/lib/jquery/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/Scripts").Include(
                        "~/Scripts/lib/bootstrap/js/bootstrap.min.js",
                        "~/Scripts/lib/isotope/isotope.min.js",
                        "~/Scripts/lib/hover/hoverdir.js",
                        "~/Scripts/lib/unveil-effects/unveil-effects.js",
                        "~/Scripts/lib/owl-carousel/owl-carousel.js",
                        "~/Scripts/lib/jetmenu/jetmenu.js",
                        "~/Scripts/lib/animate-enhanced/animate-enhanced.min.js",
                        "~/Scripts/lib/jigowatt/jigowatt.js",
                        "~/Scripts/lib/easypiechart/easypiechart.min.js",
                        "~/Scripts/js/main.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/lib/bootstrap/css/bootstrap.min.css",
                      "~/Content/lib/font-awesome/css/font-awesome.min.css",
                      "~/Content/lib/prettyphoto/css/prettyphoto.css",
                      "~/Content/lib/hover/hoverex-all.css",
                      "~/Content/lib/jetmenu/jetmenu.css",
                      "~/Content/lib/owl-carousel/owl-carousel.css",
                      "~/Content/style.css",
                      "~/Content/bbpress.css",
                      "~/Content/css/colors/blue.css"));

        }
    }
}
