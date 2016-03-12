using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using duyendang.Models;
namespace duyendang.Controllers
{
    public class BabyController : Controller
    {
        
         DUYENDANGDBEntities db = new DUYENDANGDBEntities();
        // GET: Baby
        public ActionResult Index()
        {
            //Trả về none nếu không thỏa, trả về hàng nếu thỏa điều kiện
            information info = db.information.SingleOrDefault(c => c.catalogeId == 3);

            if (info == null)
            {
                //Trả về trang báo lỗi
                Response.StatusCode = 404;
                return null;
            }

            return View(info);
        }

        //Album Be Yeu partial
        public PartialViewResult AlbumBabyPartial()
        {
            var lst = db.albums.Where(c => c.catalogeId ==3).ToList();
            // catalogeId = 3 => lay ra danh sach image cua Be Yeu
            return PartialView(lst);
        }

        public PartialViewResult AlbumBabyManapartial()
        {
            var lst = db.albums.Where(c => c.catalogeId == 3).ToList();
            // catalogeId = 3 => lay ra danh sach image cua Be Yeu
            return PartialView(lst);
        }
        [HttpGet]
        public ActionResult Edit()
        {
            var info = db.information.SingleOrDefault(c => c.catalogeId == 3);
            if (info == null)
            {
                //Trả về trang báo lỗi
                Response.StatusCode = 404;
                return null;
            }
            ViewBag.album = db.albums;
            return View(info);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection f, HttpPostedFileBase []file)
        {
            var info = db.information.SingleOrDefault(c => c.catalogeId == 3);
            var lst = db.albums.Where(c => c.catalogeId == 3).ToList();
            for (int i = 1; i < 7; i++)
            {
                if (file[i] != null && file[i].ContentLength > 0)
                {
                    string filename = System.IO.Path.GetFileName(file[i].FileName);
                    string path = Server.MapPath("~/Images/" + filename);
                    file[i].SaveAs(path);
                    lst[i-1].image = filename;
                }
            }

            string desc = f["desc"];
            info.description = desc;
            if (file[0] != null && file[0].ContentLength > 0)
            {
                string filename = System.IO.Path.GetFileName(file[0].FileName);
                string path = Server.MapPath("~/Images/" + filename);
                file[0].SaveAs(path);
                info.image = filename;
            }
            db.SaveChanges();
            return RedirectToAction("Edit");
        }
    }
}