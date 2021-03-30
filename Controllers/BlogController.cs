using Explore_California_Web.Models;
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

        [HttpGet, Route("create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, Route("create")]
        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
                return View();

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            return View();
        }

    }
}
