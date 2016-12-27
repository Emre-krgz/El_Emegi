using ElEmegi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ElEmegi.Areas.admin.Controllers
{
    public class adminUrunController : Controller
    {
        //
        // GET: /admin/adminUrun/
        ElEmegi2Context db = new ElEmegi2Context();

        public ActionResult Index()
        {
            return View(db.Urunlers.ToList());
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Urunler urunler)
        {
            if (ModelState.IsValid)
            {
                db.Urunlers.Add(urunler);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(urunler);
            }


        }
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            return View(db.Urunlers.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(Urunler k)
        {
            db.Entry(k).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]

        public ActionResult Delete(int id)
        {
            return View(db.Urunlers.Find(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult Delete_yeni(int id)
        {
            Urunler ur = db.Urunlers.Find(id);
            db.Urunlers.Remove(ur);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
