using ExtMVC1.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExtMVC1.Controllers
{
    public class Example1Controller : ExamplesController
    {
        public override IActionResult Index()
        {
            return View(new Example1Model());
        }
    }
}
