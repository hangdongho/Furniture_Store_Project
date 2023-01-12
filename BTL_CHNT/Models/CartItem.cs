using BTL_CHNT.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_CHNT.Models
{
    [Serializable]
    public class CartItem
    {
        public SAN_PHAM sanpham { set; get; }
        public int soluong { set; get; }

    }
}