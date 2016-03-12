﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using duyendang.Models;

namespace duyendang.Controllers
{
    public class IndexController : Controller
    {
        DUYENDANGDBEntities db = new DUYENDANGDBEntities();
        // GET: Index
        public ActionResult Index() 
        {
            //Trả về none nếu không thỏa, trả về hàng nếu thỏa điều kiện
            cataloge Cataloge = db.cataloges.SingleOrDefault(c => c.id == 1);// id = 1 là home

            if(Cataloge == null)
            {
                //Trả về trang báo lỗi
                Response.StatusCode = 404;
                return null;
            }
            return View(Cataloge);
        }

        //Category home partial
        public PartialViewResult CategoryHomePartial()
        {
            var lstCategory = db.cataloges.Where(c => c.show == true).ToList();
           // id từ Dịch Vụ PhotoBook đến Card Visit ở Home
             return PartialView(lstCategory);
        }

        public PartialViewResult SliderPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Edit()
        {
            cataloge Cataloge = db.cataloges.SingleOrDefault(c => c.id == 1);

            if (Cataloge == null)
            {
                //Trả về trang báo lỗi
                Response.StatusCode = 404;
                return null;
            }
            return View(Cataloge);
        }

        [HttpPost]
        public ActionResult Edit(FormCollection f, HttpPostedFileBase []file)
        {
            cataloge cata = db.cataloges.SingleOrDefault(c => c.id == 1);
            if (file[0] != null && file[0].ContentLength > 0)
            {
                string filename = System.IO.Path.GetFileName(file[0].FileName);
                string path = Server.MapPath("~/Images/" + filename);
                file[0].SaveAs(path);
                cata.image = filename;
            }
            string desc = f["desc"];
            cata.description = desc;
            db.SaveChanges();
            return RedirectToAction("Edit");
        }
    }
}