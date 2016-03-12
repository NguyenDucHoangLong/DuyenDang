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
    }
}