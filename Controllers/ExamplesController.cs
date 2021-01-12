using Ext.Net.Core;
using ExtMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExtMVC1.Controllers
{
    public class ExamplesController : Controller
    {
        public virtual IActionResult Index()
        {
            return View(new ExamplesModel());
        }

        public IActionResult Login(string role)
        {
            switch (role)
            {
                case "usr":
                    Example1Model.SetUser();
                    break;
                case "adm":
                    Example1Model.SetAdmin();
                    break;
                case "app":
                    Example1Model.SetApprover();
                    break;
                default:
                    Example1Model.Logout();
                    break;
            }

            this.X().Reload();

            return this.Direct();
        }

        public IActionResult Logout()
        {
            Example1Model.Logout();
            this.X().Reload();

            return this.Direct();
        }
    }
}
