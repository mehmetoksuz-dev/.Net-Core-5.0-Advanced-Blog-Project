using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using MehmetDevBlog.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MehmetDevBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult WriterList()
        {
            var values = wm.GetList();
            var jsonWriters = JsonConvert.SerializeObject(values);
            return Json(jsonWriters);
        }

        public IActionResult GetWriterByID(int writerid)
        {
            var findWriter = wm.GetWriterById(writerid);
            var jsonWriters = JsonConvert.SerializeObject(findWriter);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult AddWriter(string Mail, string Name, string Password)
        {
            Writer w = new Writer();
            w.WriterMail = Mail;
            w.WriterName = Name;
            w.WriterPassword = Password;
            w.WriterStatus = true;
            wm.TAdd(w);
            var jsonWriters = JsonConvert.SerializeObject(w);
            return Json(jsonWriters);
        }

        [HttpPost]
        public IActionResult DeleteWriter(int id) 
        {
            if(id != 0) { 
            var writer = wm.TGetById(id);
            wm.TDelete(writer);
            return Json(1);
            }
            else
            {
                return Json(0);
            }
            //return RedirectToAction("/Admin/Writer/Index");
        }

        public static List<Writer> writers = new List<Writer>
        {
            new Writer
            {
                WriterID=22,
                WriterName = "Mehmet"
            },
        };
    }
}
