using BTL_CHNT.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_CHNT.Models
{
    public class OrderDetailsModel
    {
        FurnitureShopDBContext db = null;
        public OrderDetailsModel()
        {
            db = new FurnitureShopDBContext();
        }
        public bool Insert(CHITIET_DH orderdetail)
        {
            try
            {
                db.CHITIET_DH.Add(orderdetail);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
    }
}