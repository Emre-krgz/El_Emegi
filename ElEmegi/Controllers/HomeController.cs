using ElEmegi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElEmegi.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        ElEmegi2Context db = new ElEmegi2Context();
        public ActionResult Index()
        {
            var urunler = db.Urunlers.Where(x => x.id > 0);
            return View(urunler);
        }

    }
}
