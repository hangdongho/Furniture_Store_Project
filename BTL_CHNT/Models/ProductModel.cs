using BTL_CHNT.Models.Entities;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_CHNT.Models
{
    public class ProductModel
    {
        private FurnitureShopDBContext context = null;
        public ProductModel()
        {
            context = new FurnitureShopDBContext();
        }
        public SAN_PHAM ViewDetail(int masp)
        {
            return context.SAN_PHAM.Find(masp);
        }
        public int Insert(SAN_PHAM entity)
        {
            context.SAN_PHAM.Add(entity);
            context.SaveChanges();
            return entity.masanpham;
        }
        public bool Update(SAN_PHAM entity)
        {
            try
            {
                var product = context.SAN_PHAM.Find(entity.masanpham);
                product.maloaisp = entity.maloaisp;
                product.mathuonghieu = entity.mathuonghieu;
                product.tensanpham = entity.tensanpham;
                product.hinhanh = entity.hinhanh;
                product.mota = entity.mota;
                product.tinhtrang = entity.tinhtrang;
                product.gia = entity.gia;
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Delete(int masp)
        {
            try
            {
                var product = context.SAN_PHAM.Find(masp);
                context.SAN_PHAM.Remove(product);
                context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public SAN_PHAM GetbyId(string name)
        {
            return context.SAN_PHAM.SingleOrDefault(x => x.tensanpham == name);
        }

        public IEnumerable<SAN_PHAM> ListAllPaging(string searchString, int page, int pageSize)
        {
            IQueryable<SAN_PHAM> model = context.SAN_PHAM;
            if (!string.IsNullOrEmpty(searchString))
            {
                model = model.Where(x => x.tensanpham.Contains(searchString) || x.tensanpham.Contains(searchString));
            }
            return model.OrderBy(x => x.masanpham).ToPagedList(page, pageSize);
        }
    }
}