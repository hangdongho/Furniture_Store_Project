namespace BTL_CHNT.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHI_TIET_PNK
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CHI_TIET_PNK()
        {
            CHITIET_SP_NHAP = new HashSet<CHITIET_SP_NHAP>();
        }

        [Key]
        public int machitietPNK { get; set; }

        public int? maphieunk { get; set; }

        public int? masanpham { get; set; }

        public int soluong { get; set; }

        public virtual PHIEU_NK PHIEU_NK { get; set; }

        public virtual SAN_PHAM SAN_PHAM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIET_SP_NHAP> CHITIET_SP_NHAP { get; set; }
    }
}
