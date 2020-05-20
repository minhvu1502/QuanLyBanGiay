using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyBanGiay.Models
{
    public class CreateAccountModel
    {
        public string username { get; set; }
        public string password { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}