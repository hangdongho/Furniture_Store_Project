namespace BTL_CHNT.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DON_HANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DON_HANG()
        {
            CHITIET_DH = new HashSet<CHITIET_DH>();
        }

        [Key]
        public int madonhang { get; set; }

        public int? mataikhoan { get; set; }

        [Required]
        [StringLength(50)]
        public string nguoinhan { get; set; }

        [Required]
        [StringLength(50)]
        public string sodienthoai { get; set; }

        [Required]
        [StringLength(50)]
        public string diachi { get; set; }

        [Required]
        [StringLength(50)]
        public string email { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaydat { get; set; }

        [Required]
        [StringLength(50)]
        public string trangthai { get; set; }

        public bool thanhtoan { get; set; }

        [Required]
        [StringLength(30)]
        public string loaidh { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_DH> CHITIET_DH { get; set; }

        public virtual TAI_KHOAN TAI_KHOAN { get; set; }
    }
}
