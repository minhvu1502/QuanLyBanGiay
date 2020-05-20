namespace QuanLyBanGiay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tChiTietHoaDon")]
    public partial class tChiTietHoaDon
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaHD { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }

        public int? SoLuong { get; set; }

        public virtual tHoaDon tHoaDon { get; set; }

        public virtual tSanPham tSanPham { get; set; }
    }
}
