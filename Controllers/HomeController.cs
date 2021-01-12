using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;

using Ext.Net;
using Ext.Net.Core;

using ExtMVC1.Models;

namespace ExtMVC1.Controllers
{
    public class HomeController : ViewEngineController
    {
        public HomeController(ICompositeViewEngine viewEngine) : base(viewEngine) { }

        public IActionResult Index() => View();

        public IActionResult Dashboard() => View();

        public IActionResult SpecialDashboard()
        {
            return ExtNetPartial();
        }

        #region Direct events
        public IActionResult ToggleSpecial()
        {
            HomeModel.IAmSpecial = !HomeModel.IAmSpecial;

            this.X().Toast("I am " + (HomeModel.IAmSpecial ? "now" : "no longer") + " special.");
            this.GetCmp<Button>("MkSpecialBtn").Text = HomeModel.SpecialButtonLabel;

            return this.Direct();
        }

        public IActionResult AmISpecial()
        {
            this.X().Toast("I <b>" + (HomeModel.IAmSpecial ? "am" : "am not") + "</b> special.");

            return this.Direct();
        }
        #endregion Direct events
    }
}