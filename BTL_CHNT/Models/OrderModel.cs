using BTL_CHNT.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_CHNT.Models
{
    public class OrderModel
    {
        FurnitureShopDBContext db = null;
        public OrderModel()
        {
            db = new FurnitureShopDBContext();
        }
        public int Insert(DON_HANG order)
        {
            db.DON_HANG.Add(order);
            db.SaveChanges();
            return order.madonhang;
        }
    }
}