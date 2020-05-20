namespace QuanLyBanGiay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tHoaDon")]
    public partial class tHoaDon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tHoaDon()
        {
            tChiTietHoaDon = new HashSet<tChiTietHoaDon>();
        }

        [Key]
        public int MaHD { get; set; }

        [Required]
        [StringLength(50)]
        public string TenTK { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayDat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tChiTietHoaDon> tChiTietHoaDon { get; set; }

        public virtual tTaiKhoan tTaiKhoan { get; set; }
    }
}
