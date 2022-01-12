using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;

namespace MehmetDevBlog.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult PartialAddComment(Comment p) //partial view ama action döndürüyor ajax ile değişebilir duruma göre
        {
            Context c = new Context();
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            //Burada solidi deldik aslında context burada kullanılmamalı
            p.BlogID = c.Blogs.Select(x => x.BlogID).FirstOrDefault();
            cm.CommentAdd(p);
            return RedirectToAction("BlogReadAll", "Blog", new { id = c.Blogs.Select(x => x.BlogID).FirstOrDefault() });
        }
        public PartialViewResult CommentListByBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}
