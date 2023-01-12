namespace BTL_CHNT.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SAN_PHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SAN_PHAM()
        {
            CHI_TIET_PNK = new HashSet<CHI_TIET_PNK>();
            CHITIET_DH = new HashSet<CHITIET_DH>();
            CHITIET_SP_NHAP = new HashSet<CHITIET_SP_NHAP>();
            DANH_GIA = new HashSet<DANH_GIA>();
        }

        [Key]
        public int masanpham { get; set; }

        public int? maloaisp { get; set; }

        public int? mathuonghieu { get; set; }

        [Required]
        [StringLength(255)]
        public string tensanpham { get; set; }

        [Required]
        [StringLength(255)]
        public string hinhanh { get; set; }

        [Required]
        [StringLength(255)]
        public string mota { get; set; }

        [Required]
        [StringLength(30)]
        public string tinhtrang { get; set; }

        public int gia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHI_TIET_PNK> CHI_TIET_PNK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_DH> CHITIET_DH { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_SP_NHAP> CHITIET_SP_NHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANH_GIA> DANH_GIA { get; set; }

        public virtual LOAI_SAN_PHAM LOAI_SAN_PHAM { get; set; }

        public virtual THUONG_HIEU THUONG_HIEU { get; set; }
    }
}
