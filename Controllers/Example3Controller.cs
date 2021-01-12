using ExtMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExtMVC1.Controllers
{
    /// <summary>
    /// See also:
    ///   /Views/Example3/index.cshtml
    ///   /Views/Shared/Components/AdminPanel/Default.cshtml
    ///   /Views/Shared/Components/Header/Default.cshtml
    ///   /Views/Shared/Components/Login/Login.cshtml
    ///   /Views/Shared/Components/Login/Logout.cshtml
    ///   /ViewComponents/AdminPanel.cs
    ///   /ViewComponents/Header.cs
    ///   /ViewComponents/Login.cs
    /// </summary>
    public class Example3Controller : ExamplesController
    {
        public override IActionResult Index()
        {
            return View(new Example3Model());
        }
    }
}
