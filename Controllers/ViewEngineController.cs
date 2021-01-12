using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.IO;

namespace ExtMVC1.Controllers
{
    public class ViewEngineController : Controller
    {
        protected ICompositeViewEngine viewEngine;

        public ViewEngineController(ICompositeViewEngine viewEngine)
        {
            this.viewEngine = viewEngine;
        }

        protected string RenderViewAsString(object model, string viewName = null)
        {
            viewName = viewName ?? ControllerContext.ActionDescriptor.ActionName;
            ViewData.Model = model;

            using (StringWriter sw = new StringWriter())
            {
                IView view = viewEngine.FindView(ControllerContext, viewName, true).View;
                ViewContext viewContext = new ViewContext(ControllerContext, view, ViewData, TempData, sw, new HtmlHelperOptions());

                view.RenderAsync(viewContext).Wait();

                return sw.GetStringBuilder().ToString();
            }
        }

/*
<html>
    <head>
        <title>bleh</title>
        <link type="text/css" rel="stylesheet" href="/extnet/extjs/packages/theme-spotless/build/resources/theme-spotless-all-debug.css"/>
    <script type="text/javascript" src="/extnet/extjs/ext-all-debug.js"></script>
    <script type="text/javascript" src="/extnet/extnet/extnet-all-debug.js"></script>
    <script type="text/javascript" src="/extnet/extjs/packages/theme-spotless/build/theme-spotless-debug.js"></script>
    <script type="text/javascript">
        Ext.net.ResourceMgr.init({isMVC:true,ns:"App",theme:"spotless",csrfHeader:"RequestVerificationToken",csrfToken:"CfDJ8BBnP8RStWtFkwK7SaT3FR8MRR21DnvpRRiFHLgufZxMhOCD2DsNejQIeEy3K37EZSIEAYEHyzY_QTGRa_4WITDBEFYGK0R0AGF8xiZKfvcOP6_4s-WmudiMcC6HQPY6nu3nJ89AQ0kkzRGF8fFMjZA"});
        Ext.onReady(function() {
            Ext.create("Ext.button.Button",{id:"ctl01",renderTo:"App.ctl01_Container",text:"Special Dashboard button."});
        });
    </script>
</head>
    <body>
        <div id="App.ctl01_Container"></div>
    </body>
</html>
*/
        protected IActionResult ExtNetPartial(object model = null, string viewName = null)
        {
            var html = RenderViewAsString(model, viewName);

            var scriptStartPos = html.IndexOf("Ext.create(");
            if (scriptStartPos < 0) throw new Exception("Page has no script block.");

            var scriptEndPos = html.IndexOf(Environment.NewLine + "        });" + Environment.NewLine + "    </script>", scriptStartPos);
            if (scriptEndPos < 0) throw new Exception("Unable to locate proper page script end block.");

            var script = html.Substring(scriptStartPos, scriptEndPos - scriptStartPos);

            return Content(script);
        }
    }
}