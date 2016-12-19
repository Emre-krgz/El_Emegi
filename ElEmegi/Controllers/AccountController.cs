using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ElEmegi.Models;

namespace ElEmegi.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Index()
        {
            using (ElEmegi2Context db = new ElEmegi2Context())
            {
                return View(db.musterilers.ToList());
            }
        }
          [HttpGet]
        public ActionResult Register()
        {
            return View();
        }
         [HttpPost]
          public ActionResult Register(musteriler musteri)
        {
            if (ModelState.IsValid)
            {
                using (ElEmegi2Context db = new ElEmegi2Context())
                {
                    db.musterilers.Add(musteri);
                    db.SaveChanges();
                }
                ModelState.Clear();
                ViewBag.Message = musteri.kullanici_adi + "" + musteri + "kayıt başarılı";
            }
            return View();
        }
         [HttpGet]
         public ActionResult Login()
         {
             return View();
         }

         [HttpPost]
         [ValidateAntiForgeryToken]
         public ActionResult Login(musteriler objUser)
         {
             if (ModelState.IsValid)
             {
                 using (ElEmegi2Context db = new ElEmegi2Context())
                 {
                     var obj = db.musterilers.Where(a => a.kullanici_adi.Equals(objUser.kullanici_adi) && a.sifre.Equals(objUser.sifre)).FirstOrDefault();
                     if (obj != null)
                     {
                         Session["UserID"] = obj.kullanici_adi.ToString();
                        

                         return RedirectToAction("Index", "Home");
                     }
                     else
                     {
                         ModelState.AddModelError("", "kullanıcı adı veya şifre yanlış");
                     }
                 }
             }
             return View();
         }
         public ActionResult Logout()
         {
             //if (Session["UserID"]==null)
             //{
                 
             //}
             Session.Clear();
             return RedirectToAction("Index", "Home");
         }

    }
}
