using ExtMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExtMVC1.Controllers
{
    public class Example2Controller : ExamplesController
    {
        public override IActionResult Index()
        {
            return View(new Example2Model());
        }
    }
}
