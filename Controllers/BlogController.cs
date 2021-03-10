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
            return new ContentResult { Content = "Blog posts" };
        }
         [Route("{year:min(2000)}/{month:int}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            return new ContentResult { 
            Content = string.Format("Year: {0}; Month: {1}; Key: {2}",
                                     year, month, key)
            };
        }
    }
}
