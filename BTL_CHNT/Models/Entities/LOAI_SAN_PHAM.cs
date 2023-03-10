namespace BTL_CHNT.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class LOAI_SAN_PHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAI_SAN_PHAM()
        {
            SAN_PHAM = new HashSet<SAN_PHAM>();
        }

        [Key]
        public int maloaisp { get; set; }

        [Required]
        [StringLength(255)]
        public string tenloaisp { get; set; }

        [Required]
        [StringLength(255)]
        public string mota { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SAN_PHAM> SAN_PHAM { get; set; }
    }
}
