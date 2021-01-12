using ExtMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExtMVC1.ViewComponents
{
    /// <summary>
    /// See also:
    ///   /Controllers/Example3Controller.cs
    ///   /Views/Example3/index.cshtml
    ///   /Views/Shared/Components/Header/Default.cshtml
    ///   /ViewComponents/Login.cs
    /// </summary>

    public class Header : ViewComponent
    {
        public IViewComponentResult Invoke(Example3Model.Roles role) => (role != ExamplesModel.Roles.Guest) ? View() : Content(string.Empty);
    }
}
