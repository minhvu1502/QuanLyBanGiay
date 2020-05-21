using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyBanGiay.Common;
using QuanLyBanGiay.Models;

namespace QuanLyBanGiay.Controllers
{
    public class CartController : Controller
    {
        WebBanGiay db = new WebBanGiay();
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(CartAddModel model)
        {
            var TenTK = (CustomerModel) Session[SessionContants.LOGIN];
            if (TenTK == null)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                DateTime date = DateTime.Now;
                var MaGioHang = date.Day.ToString()+date.Month.ToString()+date.Year.ToString();
                CartModel cart = new CartModel()
                {
                    MaGioHang = Convert.ToInt32(MaGioHang)
                };
                Session.Add(SessionContants.CART, cart);
                var session_cart = (CartModel)Session[SessionContants.CART];
                tGioHang gioHang = new tGioHang();
                gioHang.MaGioHang = session_cart.MaGioHang;
                gioHang.TenTK = TenTK.TenTK;
                db.tGioHang.Add(gioHang);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
        }
    }
}