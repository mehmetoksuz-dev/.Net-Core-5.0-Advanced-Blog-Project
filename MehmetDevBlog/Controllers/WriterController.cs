using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using MehmetDevBlog.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MehmetDevBlog.Controllers
{
    //[Authorize] gerek kalmadi startup.cs den kontrol

    public class WriterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [Authorize]
        //[AllowAnonymous]
        public IActionResult Index()
        {
            var userMail = User.Identity.Name; //mail al
            ViewBag.v = userMail;
            Context c = new Context();
            var writerName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writerName;
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        public IActionResult WriterMail()
        {
            return View();
        }
        public IActionResult Test() //test veri dönecek mi?
        {
            return View();
        }
        public PartialViewResult WriterNavbarPartial() //navar partial oldu
        {
            var userMail = User.Identity.Name; //mail al
            Context c = new Context();
            var writerName = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            TempData["test"] = writerName;
            return PartialView();
        }
        
        public PartialViewResult WriterFooterPartial() //footer partial oldu
        {
            return PartialView();
        }
        [HttpGet]
        public IActionResult WriterEditProfile() 
        {
            Context c = new Context();
            var userMail = User.Identity.Name;
            var writerId = c.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterID).FirstOrDefault();
            var writervalues = wm.TGetById(writerId);
            return View(writervalues);
        }
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p)
        {
            WriterValidator wvl = new WriterValidator(); //validatoru cagir
            ValidationResult results = wvl.Validate(p); //parametreyi al
            if (results.IsValid) //validationrules sagliyor mu?
            {
                wm.TUpdate(p);
                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage p)
        {
            Writer w = new Writer();
            if (p.WriterImage != null)
            {
                var extension = Path.GetExtension(p.WriterImage.FileName); //uzantı ve name
                var newImageName = Guid.NewGuid()+extension; //Guid benzersiz isim tanımlamak için kullanılır.
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName); //yol
                var stream = new FileStream(location, FileMode.Create); //yeni bir dosya akışı oluşturduk
                p.WriterImage.CopyTo(stream); //stream'e kopyala
                w.WriterImage = newImageName;
            }
            w.WriterMail = p.WriterMail;
            w.WriterName = p.WriterName;
            w.WriterPassword = p.WriterPassword;
            w.WriterStatus = true;
            w.WriterAbout = p.WriterAbout;
            wm.TAdd(w);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
