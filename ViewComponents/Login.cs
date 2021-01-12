using ExtMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExtMVC1.ViewComponents
{
    /// <summary>
    /// See also:
    ///   /Controllers/Example3Controller.cs
    ///   /Views/Example3/index.cshtml
    ///   /Views/Shared/Components/Login/Login.cshtml
    ///   /Views/Shared/Components/Login/Logout.cshtml
    ///   /ViewComponents/Login.cs
    /// </summary>
    public class Login : ViewComponent
    {
        public IViewComponentResult Invoke(bool isLogged) => View(isLogged ? "Logout" : "Login");
    }
}
