﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MehmetDevBlog.ViewComponents.Writer
{
    public class WriterNotifications : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}