using MehmetDevBlog.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MehmetDevBlog.ViewComponents
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    Username = "Mehmet"
                },

                new UserComment
                {
                    ID = 2,
                    Username = "Franz Kafka"
                },
                new UserComment
                {
                    ID = 3,
                    Username = "Alan Turing" 
                }
            };
            return View(commentValues);
        }
    }
}
