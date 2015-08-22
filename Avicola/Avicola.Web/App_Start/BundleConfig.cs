﻿using System.Web;
using System.Web.Optimization;

namespace Avicola.Web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-2.1.3.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/globalize").Include(
                        "~/Scripts/jquery.validate-vsdoc.js",
                        "~/Scripts/jquery.validate.fixes.js",
                        "~/Scripts/jquery.validate.min",
                        "~/Scripts/jquery.validate.unobtrusive.min.js",
                        "~/Scripts/jquery.validate.unobtrusive.custom.js",
                        "~/Scripts/jquery.validate.unobtrusive.extensions.js"));

            bundles.Add(new ScriptBundle("~/bundles/globalize")
                         .Include(
                             "~/Scripts/globalize.js",
                             "~/Scripts/globalize.culture.es-AR.js",
                             "~/Scripts/globalize.init.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate.js",
                        "~/Scripts/jquery.validate.unobtrusive.js",
                        "~/Scripts/jquery.validate.unobtrusive.extensions.js",
                        "~/Scripts/jquery.validate.unobtrusive.custom.js",
                        "~/Scripts/jquery.validate.fixes.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-2.8.3.js"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap-datepicker.js",
                      "~/Scripts/bootstrap-datepicker.es.js",
                      "~/Scripts/fileinput.js",
                      "~/Scripts/fileinput_locale_es.js",
                      "~/Scripts/ImageUploadValidation.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new ScriptBundle("~/bundles/lib")
                .Include("~/Scripts/underscore.js")
                .Include("~/Scripts/select2.js")
                .Include("~/Scripts/autoNumeric-{version}.js")
                .Include("~/Scripts/jquery.sortable.js"));

            bundles.Add(new ScriptBundle("~/bundles/app")
                .IncludeDirectory("~/Scripts/app/utilities", "*.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap-datepicker.css",
                      "~/Content/bootstrap-fileinput/css/fileinput.css",
                      "~/Content/bootstrap.vertical-tabs.css",
                      "~/Content/font-awesome.css",
                      "~/Content/select2.css",
                      "~/Content/pointex-homepage.css",
                      "~/Content/site.css",
                      "~/Content/pointex-tables.css"));
        }
    }
}
