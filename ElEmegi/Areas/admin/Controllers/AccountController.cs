using ElEmegi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ElEmegi.Areas.admin.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /admin/Account/

        ElEmegi2Context db = new ElEmegi2Context();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection form)
        {
            string username = form["username"].ToString();
            string password = form["password"].ToString();
            var usr = (from u in db.musterilers
                       where u.kullanici_adi == username && u.sifre == password
                       select u).FirstOrDefault();

            if (usr != null)
            {
                Session["UserID"] = usr.kullanici_adi.ToString();
                FormsAuthentication.SetAuthCookie(usr.kullanici_adi, false);
                return RedirectToAction("Index", "AdminHome");
            }
            TempData["Message"] = "Kullanıcı ve Şifre Yanlış";
            return View();

        }
        public ActionResult Logout()
        {
            Session.Clear();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login", "Account");
        }

    }
}
