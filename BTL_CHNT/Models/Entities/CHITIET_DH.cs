namespace BTL_CHNT.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHITIET_DH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHITIET_DH()
        {
            CHITIET_SP_NHAP = new HashSet<CHITIET_SP_NHAP>();
        }

        [Key]
        public int machitietDH { get; set; }

        public int? masanpham { get; set; }

        public int? madonhang { get; set; }

        public int soluong { get; set; }

        public int gia { get; set; }

        [Required]
        [StringLength(50)]
        public string trangthai { get; set; }

        public bool thanhtoan { get; set; }

        public virtual DON_HANG DON_HANG { get; set; }

        public virtual SAN_PHAM SAN_PHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_SP_NHAP> CHITIET_SP_NHAP { get; set; }
    }
}
