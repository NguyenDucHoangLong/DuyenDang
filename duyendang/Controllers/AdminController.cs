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
                return RedirectToAction("Index");
            }
            else
            {
                Session["user"] = username;
                Session["password"] = password;
                return RedirectToAction("Edit", "Index");
            }
        }

        public ActionResult Manager()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                string user = Session["user"].ToString();
                string password = Session["password"].ToString();
                return View();
            }
        }

        public ActionResult ChangePassword(FormCollection f)
        {
            //string user = f["user"];
            string oldpassword = f["oldPassword"];
            string newpassword = f["newPassword1"];
            string confirmpass = f["newPassword"];

            if (newpassword == confirmpass)
            {
                string user = Session["user"].ToString();
                user account = db.users.Where(a => a.name == user && a.password == oldpassword).FirstOrDefault();
                if (account != null)
                {
                    account.password = newpassword;
                    db.SaveChanges();
                    Session["password"] = newpassword;
                }
            }
            return RedirectToAction("Manager");
        }



    }
}