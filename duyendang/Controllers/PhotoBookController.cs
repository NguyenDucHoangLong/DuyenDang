using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace duyendang.Controllers
{
    public class PhotoBookController : Controller
    {
        // GET: PhotoBook
        public ActionResult Index()
        {
            ViewBag.Title = "PhotoBook";

            return View();
        }
    }
}