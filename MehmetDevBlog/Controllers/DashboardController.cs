using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MehmetDevBlog.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            Context c = new Context();
            ViewBag.totalBlogs = c.Blogs.Count().ToString();
            ViewBag.numYourBlogs = c.Blogs.Where(x => x.Writer.WriterMail == userMail).Count();
            ViewBag.numTotalCategory = c.Categories.Count();
            return View();
        }
    }
}
