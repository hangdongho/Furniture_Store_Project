using BTL_CHNT.Models;
using BTL_CHNT.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTL_CHNT.Areas.Admin.Controllers
{
    public class ProductController : Controller
    {
        // GET: Admin/Product
        public ActionResult Index(string searchString, int page = 1, int pageSize = 5)
        {
            var db = new ProductModel();
            var model = db.ListAllPaging(searchString, page, pageSize);
            return View(model);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var product = new ProductModel().ViewDetail(id);
            return View(product);
        }
        [HttpPost]
        public ActionResult Create(SAN_PHAM product)
        {
            if (ModelState.IsValid)
            {
                var model = new ProductModel();
                int id = model.Insert(product);
                if (id > 0)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Them san pham thanh cong");
                }
            }
            return View("Index");
        }
        [HttpPost]
        public ActionResult Edit(SAN_PHAM product)
        { 
            if (ModelState.IsValid)
            {
                var model = new ProductModel();
                var result = model.Update(product);
                if (result)
                {
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Cap nhat san pham thanh cong");
                }
            }
            return View("Index");

        }
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            new ProductModel().Delete(id);
            return RedirectToAction("Index");
        }
    }
}