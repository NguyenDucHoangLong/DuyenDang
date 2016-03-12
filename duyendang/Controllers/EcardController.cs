using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using duyendang.Models;

namespace duyendang.Controllers
{
    public class EcardController : Controller
    {
        DUYENDANGDBEntities db = new DUYENDANGDBEntities();

        // GET: Ecard
        public ActionResult Index()
        {
            var alb = db.albums.Where(a => a.catalogeId == 6).ToList();

            if (alb == null)
            {
                //Trả về trang báo lỗi
                Response.StatusCode = 404;
                return null;
            }
            return View(alb);
        }
        [HttpGet]
        public ActionResult Edit()
        {
            if (Session["user"] == null)
                return RedirectToAction("Index", "Admin");
            else
            {
                var alb = db.albums.Where(a => a.catalogeId == 6).ToList();

                if (alb == null)
                {
                    //Trả về trang báo lỗi
                    Response.StatusCode = 404;
                    return null;
                }
                return View(alb);
            }

        }

        [HttpPost]
        public ActionResult Edit(HttpPostedFileBase[] file)
        {
            var alb = db.albums.Where(a => a.catalogeId == 6).ToList();

            for (int i = 0; i <= 2; i++)
            {
                if (file[i] != null && file[i].ContentLength > 0)
                {
                    string filename = System.IO.Path.GetFileName(file[i].FileName);
                    string path = Server.MapPath("~/Images/" + filename);
                    file[i].SaveAs(path);
                    alb[i].image = filename;
                }
            }

            db.SaveChanges();
            return RedirectToAction("Edit");
        }
    }
}