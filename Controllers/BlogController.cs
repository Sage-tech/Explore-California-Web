using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Explore_California_Web.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        [Route("")] 
        public IActionResult Index()
        { 
            return View();
        }
        [Route("{year:min(2000)}/{month:int}/{key}")]
        public IActionResult Post(int year, int month, string key)
       
            {

            ViewBag.Title = "Myblog post";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Author = "Sierra Soto";
            ViewBag.Body = "This is a great blog post, don't you think?";
    

            return View();
        }
    }
}
