namespace BTL_CHNT.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CHITIET_SP_NHAP
    {
        [Key]
        public int sothutu { get; set; }

        public int? masanpham { get; set; }

        public int? machitietPNK { get; set; }

        public int? machitietDH { get; set; }

        public int soluong { get; set; }

        public int gia { get; set; }

        public virtual CHI_TIET_PNK CHI_TIET_PNK { get; set; }

        public virtual CHITIET_DH CHITIET_DH { get; set; }

        public virtual SAN_PHAM SAN_PHAM { get; set; }
    }
}
