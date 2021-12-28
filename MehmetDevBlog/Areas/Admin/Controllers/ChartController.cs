using MehmetDevBlog.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MehmetDevBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass { categoryname = "tech", categorycount = 10 });
            list.Add(new CategoryClass { categoryname = "software", categorycount = 12 });
            list.Add(new CategoryClass { categoryname = "sports", categorycount = 5 });
            list.Add(new CategoryClass { categoryname = "denemememo", categorycount = 4 });

            return Json(new { jsonlist = list});
        }
    }
}
