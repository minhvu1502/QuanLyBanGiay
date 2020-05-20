namespace QuanLyBanGiay.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tTaiKhoan")]
    public partial class tTaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tTaiKhoan()
        {
            tHoaDon = new HashSet<tHoaDon>();
        }

        [Key]
        [StringLength(50)]
        public string TenTK { get; set; }

        [StringLength(50)]
        public string Password { get; set; }

        [StringLength(50)]
        public string TenKH { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgaySinh { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tHoaDon> tHoaDon { get; set; }
    }
}
