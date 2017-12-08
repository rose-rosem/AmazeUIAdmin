using System.Web;
using System.Web.Optimization;

namespace NewStaffWeb
{
    public class BundleConfig
    {
        // 有关绑定的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            //以下代码是自动生成的
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // 使用要用于开发和学习的 Modernizr 的开发版本。然后，当你做好
            // 生产准备时，请使用 http://modernizr.com 上的生成工具来仅选择所需的测试。
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));

            //以下由zq编写
            bundles.Add(new ScriptBundle("~/jquerymin/js").Include(
                        "~/assets/js/jquery.min.js"));

            bundles.Add(new ScriptBundle("~/theme/js").Include(
                        "~/assets/js/theme.js"));

            bundles.Add(new ScriptBundle("~/amazeui/js").Include(
                        "~/assets/js/amazeui.min.js",
                        "~/assets/js/app.js"));

            bundles.Add(new ScriptBundle("~/index/js").Include(
                        "~/assets/js/amazeui.min.js",
                        "~/assets/js/amazeui.datatables.min.js",
                        "~/assets/js/dataTables.responsive.min.js",
                        "~/assets/js/app.js"));

            bundles.Add(new StyleBundle("~/amazeui/css").Include(
                      "~/assets/css/amazeui.min.css",
                      "~/assets/css/amazeui.datatables.min.css",
                      "~/assets/css/app.css"));

        }
    }
}
