using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyBanGiay.Models;

namespace QuanLyBanGiay.Controllers
{
    public class HomeController : Controller
    {
        WebBanGiay db = new WebBanGiay();
        public ActionResult Index()
        {
            return View(db.tSanPham.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}