using duyendang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace duyendang.Controllers
{
    public class PhotoBookController : Controller
    {
        DUYENDANGDBEntities db = new DUYENDANGDBEntities();
        // GET: PhotoBook
        public ActionResult Index()
        {
            var lst = db.information.Where(c => c.catalogeId == 2).ToList();
            return View(lst);
        }

        [HttpGet]
        public ActionResult Edit()
        {
            var lst = db.information.Where(c => c.catalogeId == 2).ToList();
            return View(lst);
        }
            
        [HttpPost]
        public ActionResult Edit(FormCollection formContent, HttpPostedFileBase[] file)
        {
            var lst = db.information.Where(c => c.catalogeId == 2).ToList();
            
            for (int i = 0; i < lst.Count; i++)
            {
                if (file[i] != null && file[i].ContentLength > 0)
                {
                    string filename = System.IO.Path.GetFileName(file[i].FileName);
                    string path = Server.MapPath("~/Images/" + filename);
                    file[i].SaveAs(path);
                    lst[i].image = filename;
                }
                String nameDesc = lst[i].id.ToString();
                lst[i].description = formContent[nameDesc];
            }
            db.SaveChanges();
            return RedirectToAction("Edit");
        }
    }
}