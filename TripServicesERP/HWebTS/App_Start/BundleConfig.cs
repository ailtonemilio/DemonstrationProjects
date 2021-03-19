using System.Web;
using System.Web.Optimization;

namespace HWebTS
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            // Template CSS
            bundles.Add(new StyleBundle("~/Bundles/css")
               .Include("~/Content/metis/lib/bootstrap/css/bootstrap.css")
               //.Include("~/Content/metis/lib/bootstrap/css/bootstrap.min.css")
               .Include("~/Content/bootstrap.css")
               .Include("~/Content/bootstrap.min.css")
               .Include("~/Content/bootstrap-datepicker.css")
               .Include("~/Content/bootstrap-datepicker.min.css")
               .Include("~/Content/metis/lib/timepicker/css/bootstrap-timepicker.min.css")
               .Include("~/Content/themes/base/jquery-ui.min.css")
               .Include("~/Content/font-awesome.css")
               .Include("~/Content/metis/css/main.css")
               .Include("~/Content/metis/lib/metismenu/metisMenu.css")
               .Include("~/Content/metis/lib/onoffcanvas/onoffcanvas.css")
               .Include("~/Content/bootstrap_custom.css")
               .Include("~/Scripts/sweetalert/sweetalert.css")

                //JQuery DataTable
                .Include("~/Content/DataTables/css/dataTables.bootstrap.min.css")
                .Include("~/Content/font-awesome.min.css")

               //Bootstrap DateTimePicker
               .Include("~/Content/bootstrap-datetimepicker.min.css")

               );

            // Template Scripts
            bundles.Add(new ScriptBundle("~/bundles/jqueryval")
               //Metis
               .Include("~/Content/metis/lib/jquery/jquery.js")
               .Include("~/Content/metis/lib/bootstrap/js/bootstrap.js")
               //Esta comentado porque esta dando bug no modal do bootstrap, existe outro bootstrap.min.js no sistema que ja faz essa funcao.
               //.Include("~/Content/metis/lib/bootstrap/js/bootstrap.min.js")
               .Include("~/Content/metis/lib/timepicker/js/bootstrap-timepicker.min.js")
               .Include("~/Content/metis/lib/metismenu/metisMenu.js")
               .Include("~/Content/metis/lib/onoffcanvas/onoffcanvas.js")
               .Include("~/Content/metis/lib/screenfull/screenfull.js")
               .Include("~/Content/metis/js/core.js")
               .Include("~/Content/metis/js/app.js")
               .Include("~/Content/metis/js/style-switcher.js")
               .Include("~/Scripts/bootstrap-datepicker.min.js")

               .Include("~/Scripts/sweetalert/sweetalert.js")
               .Include("~/Scripts/sweetalert/sweetalert.min.js")

               //Sequencia para rodar o DateTimePicker
               //.Include("~/Scripts/jquery-3.3.1.min.js")
               //.Include("~/Scripts/moment.js")
               //.Include("~/Scripts/moment.min.js")
               //.Include("~/Scripts/bootstrap.min.js")
               //.Include("~/Scripts/bootstrap-datetimepicker.js")
               //.Include("~/Scripts/bootstrap-datetimepicker.min.js")

               //JQuery Datatable
               //.Include("~/Scripts/jquery-3.3.1.min.js")
               //.Include("~/Scripts/DataTables/jquery.dataTables.min.js")
               //.Include("~/Scripts/DataTables/dataTables.bootstrap.min.js")
               //.Include("~/Scripts/DataTables/dataTables.responsive.min.js")
               //.Include("~/Scripts/DataTables/responsive.bootstrap.min.js")
               //.Include("~/Scripts/DataTables/dataTables.colReorder.min.js")
               
               .Include("~/Scripts/jquery.validate.js")
               .Include("~/Scripts/jquery.validate.unobtrusive.js")
               .Include("~/Scripts/jquery.validate.min.js")
               .Include("~/Scripts/jquery.validate.unobtrusive.min.js")

               .Include("~/Scripts/jquery-ui-1.12.1.min.js")
               
               .Include("~/Scripts/notify.min.js")
               .Include("~/Scripts/validator.min.js")
               .Include("~/Scripts/validator.min.js")
               );

            bundles.Add(new ScriptBundle("~/Bundles/jquery")
                .Include("~/Scripts/jquery-3.3.1.min.js"));

            //bundles.Add(new ScriptBundle("~/Bundles/datetime")
            //    .Include("~/Scripts/moment*")
            //    .Include("~/Scripts/bootstrap-datetimepicker*"));

            //bundles.Add(new ScriptBundle("~/Bundles/bootstrap")
            //    .Include("~/Scripts/bootstrap*"));




            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            //bundles.Add(new ScriptBundle("~/bundles/modernizr")
            //    .Include("~/Scripts/modernizr-*"));

        }
    }
}
