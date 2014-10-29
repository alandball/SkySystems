using System.Web.Optimization;

namespace UI
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            /***************************** JS *****************************/

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                "~/Scripts/jquery-ui.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.unobtrusive*",
                "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrapjs").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/bootstrap-datepicker.js"));

            /***************************** CSS *****************************/

            bundles.Add(new StyleBundle("~/Content/bootstrapcss").Include(
                "~/Content/bootstrap.css",
                "~/Content/override.css",
                "~/Content/datepicker.css",
                "~/Content/widget-box.css"));

            bundles.Add(new StyleBundle("~/Content/Site.css").Include(
                "~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                "~/Content/jquery-ui.css"));
        }
    }
}