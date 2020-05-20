using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using QuanLyBanGiay.Models;

namespace QuanLyBanGiay.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        WebBanGiay db = new WebBanGiay();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProductBySex(string Sex)
        {
            var list = db.tSanPham.Where(x => x.GioiTinh == Sex).ToList();
            if (list.Count == 0)
            {
                Response.StatusCode = 404;
            }

            if (Sex == "Nam")
            {
                ViewBag.Name = "Giày Nam";
            }
            else
            {
                ViewBag.Name = "Giày Nữ";
            }
            return View(list);
        }

        public ActionResult ProductDetail(string MaSp)
        {
            var item = db.tSanPham.SingleOrDefault(x => x.MaSP == MaSp);
            return View(item);
        }
    }
}