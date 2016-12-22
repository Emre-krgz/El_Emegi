using ElEmegi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElEmegi.Areas.admin.Controllers
{
    public class AdminHomeController : Controller
    {
        //
        // GET: /admin/AdminHome/
        ElEmegi2Context db = new ElEmegi2Context();
        public ActionResult Index()
        {
            return View(db.musterilers.ToList());
        }

    }
}
