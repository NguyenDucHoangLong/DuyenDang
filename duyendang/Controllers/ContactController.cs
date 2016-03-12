using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using duyendang.Models;
using System.Net.Mail;
using System.Net;
using System.Threading.Tasks;

namespace duyendang.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> SendEmail(FormCollection f)
        {
            if (ModelState.IsValid)
            {
                string fullname = f["fullname"];
                string phone = f["phone"];
                string email = f["email"];
                string content = f["content"];
                var body = "<p>Họ Tên: {0} </p>" +
                            "<p>SDT: {1} </p>" +
                            "<p>Email: {2} </p>" +
                            "<p>Nội Dung:</p>" +
                            "<p>{3}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("@gmail.com"));  // lưu tài khoản email
                message.From = new MailAddress("@gmail.com");
                message.Subject = "Liên Hệ Từ Khách hàng DuyenDang.net";
                message.Body = string.Format(body, fullname, phone, email, content);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "",  // email gửi đi
                        Password = ""  // mật khẩu
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 25;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Index", "index");
                }
            }
            return RedirectToAction("Index","Index");
        }
    }
}