using ElEmegi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElEmegi.Controllers
{
    public class UrunlerController : Controller
    {
        //
        // GET: /Urunler/
        ElEmegi2Context db = new ElEmegi2Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Detay(int id)
        {
            return View(db.Urunlers.FirstOrDefault(x=>x.id==id));
        }

    }
}
