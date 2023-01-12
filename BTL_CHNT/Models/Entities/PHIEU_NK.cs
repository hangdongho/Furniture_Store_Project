namespace BTL_CHNT.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PHIEU_NK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEU_NK()
        {
            CHI_TIET_PNK = new HashSet<CHI_TIET_PNK>();
        }

        [Key]
        public int maphieunk { get; set; }

        public int? mataikhoan { get; set; }

        [Column(TypeName = "date")]
        public DateTime ngaynhap { get; set; }

        [Required]
        [StringLength(50)]
        public string trangthai { get; set; }

        public double tongtien { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PNK> CHI_TIET_PNK { get; set; }

        public virtual TAI_KHOAN TAI_KHOAN { get; set; }
    }
}
