using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
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
        //[AllowAnonymous]
        public IActionResult Index()
        {
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
        [AllowAnonymous]
        public IActionResult Test() //test veri dönecek mi?
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial() //navar partial oldu
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial() //footer partial oldu
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterEditProfile() 
        {
            var writesvalues = wm.TGetById(1);
            return View(writesvalues);
        }
        [AllowAnonymous]
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
