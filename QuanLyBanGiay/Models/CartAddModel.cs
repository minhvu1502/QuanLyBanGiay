using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanGiay.Models
{
    public class CartAddModel
    {
        public string MaSP { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Anh { get; set; }
        public int SoLuong { get; set; }
        public long ThanhTien { get; set; }
    }
}