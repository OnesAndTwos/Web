using System.Web.Optimization;

namespace OnesAndTwos.Web.App_Start
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/JS/Framework").Include(
                "~/Assets/JS/Framework/jquery-{version}.js",
                "~/Assets/JS/Framework/bootstrap.js",
                "~/Assets/JS/Framework/jquery.validate.js",
                "~/Assets/JS/Framework/jquery.validate.unobtrusive.js",
                "~/Assets/JS/Framework/jquery.validate.unobtrusive-custom-for-bootstrap.js"));

            bundles.Add(new StyleBundle("~/CSS/Framework").Include(
                "~/Assets/CSS/Framework/bootstrap.css",
                "~/Assets/CSS/Framework/body.css",
                "~/Assets/CSS/Framework/bootstrap-responsive.css",
                "~/Assets/CSS/Framework/bootstrap-mvc-validation.css"
                ));

            bundles.Add(new StyleBundle("~/CSS/Site").Include(
                "~/Assets/CSS/site.css"
                ));
        }
    }
}