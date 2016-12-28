using ElEmegi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Web.UI.WebControls;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


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
      public string ResimKaydet(HttpPostedFileBase file)
        {
            System.Drawing.Image orj = System.Drawing.Image.FromStream(file.InputStream);
            string yol = Path.GetFileNameWithoutExtension(file.FileName) + Guid.NewGuid() + Path.GetExtension(file.FileName);
            orj.Save(Server.MapPath("~/Content/image/"+yol));
            return yol;
        }
        [HttpPost]
        public ActionResult Create(Urunler urunler,HttpPostedFileBase resim)
        {
           
            if (ModelState.IsValid)
            {
                string yolunyolu = ResimKaydet(resim);
                urunler.ResimYol = "/Content/image/" + yolunyolu;
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
