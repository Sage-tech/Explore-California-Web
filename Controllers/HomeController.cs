using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explore_California_Web.Controllers
{
    public class HomeController : Controller
    {
        //Get: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
