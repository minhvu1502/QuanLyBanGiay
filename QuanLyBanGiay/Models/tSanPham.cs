namespace QuanLyBanGiay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tSanPham")]
    public partial class tSanPham
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tSanPham()
        {
            tChiTietGioHang = new HashSet<tChiTietGioHang>();
            tChiTietHoaDon = new HashSet<tChiTietHoaDon>();
        }

        [Key]
        [StringLength(10)]
        public string MaSP { get; set; }

        [StringLength(50)]
        public string TenSP { get; set; }

        public int? Gia { get; set; }

        [Required]
        [StringLength(50)]
        public string GioiTinh { get; set; }

        [Required]
        [StringLength(50)]
        public string TheLoai { get; set; }

        [StringLength(50)]
        public string Anh { get; set; }

        public int? sale { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tChiTietGioHang> tChiTietGioHang { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tChiTietHoaDon> tChiTietHoaDon { get; set; }
    }
}
