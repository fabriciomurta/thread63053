using ExtMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExtMVC1.ViewComponents
{
    /// <summary>
    /// See also:
    ///   /Controllers/Example3Controller.cs
    ///   /Views/Example3/index.cshtml
    ///   /Views/Shared/Components/AdminPanel/Default.cshtml
    ///   /ViewComponents/Login.cs
    /// </summary>
    public class AdminPanel : ViewComponent
    {
        public IViewComponentResult Invoke() => (ExamplesModel.CachedRole == ExamplesModel.Roles.Admin) ? View() : Content(string.Empty);
    }
}
