namespace QuanLyBanGiay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tChiTietGioHang")]
    public partial class tChiTietGioHang
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaGioHang { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaSP { get; set; }

        [Required]
        [StringLength(50)]
        public string MaSize { get; set; }

        public long? Gia { get; set; }

        public int? SoLuong { get; set; }

        public virtual tGioHang tGioHang { get; set; }

        public virtual tSanPham tSanPham { get; set; }
    }
}
