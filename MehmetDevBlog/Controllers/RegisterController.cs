using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using MehmetDevBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MehmetDevBlog.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        CitiesExample cities = new CitiesExample();
        [HttpGet] //Sayfa yuklendigi an calisiyor, kategorizasyon, listeleme vs. işlemlerinde kullanılıyor.

        public IActionResult Index()
        {
            return View(cities);
        }
        [HttpPost] //button tetiklenince calisiyor. 
        public IActionResult Index(Writer p) //get ve post tanımlanırken methodlarin isimleri ayni olmalidir for ex => ikisi de Index
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(p);
            if (results.IsValid)
            {
                p.WriterStatus = true;
                p.WriterAbout = "Deneme Test";
                wm.WriterAdd(p);
                return RedirectToAction("Index", "Blog");
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
    }
}
