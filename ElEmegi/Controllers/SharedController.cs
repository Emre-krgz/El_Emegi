﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElEmegi.Controllers
{
    public class SharedController : Controller
    {
        //
        // GET: /Shared/

        public ActionResult _Layout()
        {
            return View();
        }

    }
}