using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace asp_practice_app.Controllers
{
    public class StaticPagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}