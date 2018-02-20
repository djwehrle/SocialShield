using System.Web.Optimization;

namespace SocialShield
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/core").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/modernizr-*",
                "~/Scripts/umd/popper.js",
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/dataTables").Include(
                "~/Scripts/DataTables/jquery.dataTables.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));
            
            bundles.Add(new StyleBundle("~/Content/core.bundle").Include(
                "~/Content/bootstrap.css",
                "~/Content/site.css"));

            bundles.Add(new StyleBundle("~/Content/DataTables/css/dataTables.bundle").Include(
                "~/Content/DataTables/css/jquery.dataTables.css"));
        }
    }
}