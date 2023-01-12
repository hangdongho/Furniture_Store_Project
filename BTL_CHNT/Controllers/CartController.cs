using BTL_CHNT.Models;
using BTL_CHNT.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace BTL_CHNT.Controllers
{
    public class CartController : Controller
    {
        private const string CartSession = "CartSession";
        // GET: Cart
        public ActionResult Index()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }
        public JsonResult DeleteAll()
        {
            Session[CartSession] = null;
            return Json(new
            {
                status = true
            });
        }
        public JsonResult Delete(int masp)
        {
            var sessionCart = (List<CartItem>)Session[CartSession];
            sessionCart.RemoveAll(x => x.sanpham.masanpham == masp);
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }
        public JsonResult Update(string cartModel)
        {
            var jsonCart = new JavaScriptSerializer().Deserialize<List<CartItem>>(cartModel);
            var sessionCart = (List<CartItem>)Session[CartSession];
            foreach(var item in sessionCart)
            {
                var jsonItem = jsonCart.SingleOrDefault(x => x.sanpham.masanpham == item.sanpham.masanpham);
                if(jsonItem != null)
                {
                    item.soluong = jsonItem.soluong;
                }
            }
            Session[CartSession] = sessionCart;
            return Json(new
            {
                status = true
            });
        }
        public ActionResult AddItem(int masp, int sl)
        {
            var sanpham = new ProductModel().ViewDetail(masp);
            var cart = Session[CartSession];
            if (cart != null)
            {
                var list = (List<CartItem>)cart;
                if (list.Exists(x => x.sanpham.masanpham == masp))
                {
                    foreach (var item in list)
                    {
                        if (item.sanpham.masanpham == masp)
                        {
                            item.soluong += sl;
                        }
                    }
                }
                else
                {
                    //tao moi doi tuong cart item
                    var item = new CartItem();
                    item.sanpham = sanpham;
                    item.soluong = sl;
                    list.Add(item);
                }
                //gan vao session
                Session[CartSession] = list;
            }
            else
            {
                //tao moi doi tuong cart item
                var item = new CartItem();
                item.sanpham = sanpham;
                item.soluong = sl;
                var list = new List<CartItem>();
                list.Add(item);
                // gan vao session
                Session[CartSession] = list;
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Payment()
        {
            var cart = Session[CartSession];
            var list = new List<CartItem>();
            if (cart != null)
            {
                list = (List<CartItem>)cart;
            }
            return View(list);
        }
        [HttpPost]
        public ActionResult Payment(string shipName, string mobile, string address, string email)
        {
            var order = new DON_HANG();
            order.ngaydat = DateTime.Now;
            order.diachi = address;
            order.sodienthoai = mobile;
            order.nguoinhan = shipName;
            order.email = email;
            order.trangthai = "Dang dong hang";
            order.thanhtoan = true;
            order.loaidh = "Online";
            try
            {
                var id = new OrderModel().Insert(order);
                var cart = (List<CartItem>)Session[CartSession];
                var detailModel = new OrderDetailsModel();
                foreach (var item in cart)
                {
                    var orderdetail = new CHITIET_DH();
                    orderdetail.masanpham = item.sanpham.masanpham;
                    orderdetail.madonhang = id;
                    orderdetail.soluong = item.soluong;
                    orderdetail.gia = item.sanpham.gia;
                    orderdetail.trangthai = "Dang dong hang";
                    orderdetail.thanhtoan = true;
                    detailModel.Insert(orderdetail);
                }
            }
            catch(Exception e)
            {
                //ghi log
                throw;
            }
            return Redirect("/Cart/Success");
        }
        public ActionResult Success()
        {
            return View();
        }
    }
}