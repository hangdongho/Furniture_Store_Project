using BTL_CHNT.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_CHNT.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult RenderProduct()
        {
            FurnitureShopDBContext db = new FurnitureShopDBContext();
            List<SAN_PHAM> listHang = db.SAN_PHAM.ToList();
            return PartialView("Main", listHang);
        }
        
    }
}