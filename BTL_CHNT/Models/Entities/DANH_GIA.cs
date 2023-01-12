namespace BTL_CHNT.Models.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DANH_GIA
    {
        [Key]
        public int danhgiathu { get; set; }

        public int? mataikhoan { get; set; }

        public int? masanpham { get; set; }

        public virtual SAN_PHAM SAN_PHAM { get; set; }

        public virtual TAI_KHOAN TAI_KHOAN { get; set; }
    }
}
