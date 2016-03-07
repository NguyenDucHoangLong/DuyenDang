using System;
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
    }
}