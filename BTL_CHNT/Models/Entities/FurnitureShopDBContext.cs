using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BTL_CHNT.Models.Entities
{
    public partial class FurnitureShopDBContext : DbContext
    {
        public FurnitureShopDBContext()
            : base("name=FurnitureShopDBContext2")
        {
        }

        public virtual DbSet<CHI_TIET_PNK> CHI_TIET_PNK { get; set; }
        public virtual DbSet<CHITIET_DH> CHITIET_DH { get; set; }
        public virtual DbSet<CHITIET_SP_NHAP> CHITIET_SP_NHAP { get; set; }
        public virtual DbSet<DANH_GIA> DANH_GIA { get; set; }
        public virtual DbSet<DON_HANG> DON_HANG { get; set; }
        public virtual DbSet<LOAI_SAN_PHAM> LOAI_SAN_PHAM { get; set; }
        public virtual DbSet<PHIEU_NK> PHIEU_NK { get; set; }
        public virtual DbSet<SAN_PHAM> SAN_PHAM { get; set; }
        public virtual DbSet<TAI_KHOAN> TAI_KHOAN { get; set; }
        public virtual DbSet<THUONG_HIEU> THUONG_HIEU { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DON_HANG>()
                .Property(e => e.sodienthoai)
                .IsUnicode(false);

            modelBuilder.Entity<DON_HANG>()
                .Property(e => e.diachi)
                .IsUnicode(false);
        }
    }
}
