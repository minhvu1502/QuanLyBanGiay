using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using QuanLyBanGiay.Common;
using QuanLyBanGiay.Models;

namespace QuanLyBanGiay.Controllers
{
    public class LoginController : Controller
    {
        WebBanGiay db = new WebBanGiay();

        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var result =
                    db.tTaiKhoan.SingleOrDefault(x => x.TenTK == model.username && x.Password == model.password);
                if (result != null)
                {
                    CustomerModel customer = new CustomerModel()
                    {
                        TenTK = result.TenTK
                    };
                    Session.Add(SessionContants.LOGIN, customer);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại");
                }
            }

            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CreateAcount()
        {
            return View();
        }

    [HttpPost]
        public ActionResult CreateAcount(tTaiKhoan model)
        {
            if (ModelState.IsValid)
            {
                db.tTaiKhoan.Add(model);
                    db.SaveChanges();
                    return RedirectToAction("Index", "Login");
            }

            return View();
        }
    }
}