using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using duyendang.Models;
using System.Data.Entity;

namespace duyendang.Controllers
{
    public class AdminController : Controller
    {
        private DUYENDANGDBEntities db = new DUYENDANGDBEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CheckLogin(string username, string password)
        {
            user account = db.users.Where(a => a.name == username && a.password == password).FirstOrDefault();
            if(account == null)
            {
                ModelState.AddModelError("Fail", "Tên đăng nhập hoặc mật khẩu không đúng!");
                return null;
            }
            else
            {
                Session["user"] = username;
                return RedirectToAction("Manager");
            }
        }

        public ActionResult Manager()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index");
            else
                return View();
        }

    }
}