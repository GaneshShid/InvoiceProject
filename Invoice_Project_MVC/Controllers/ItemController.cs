using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invoice_Project_MVC.Models;
namespace Invoice_Project_MVC.Controllers
{
    public class ItemController : Controller
    {
        Invoice_DBEntities db;
        public ItemController()
        {
            db = new Invoice_DBEntities();
        }

        public JsonResult GetItems()
        {
            List<tbl_products> lst = new List<tbl_products>();
            foreach(tbl_products p in db.tbl_products.ToList())
            {
                tbl_products pr = new tbl_products() { 
                    product_id=p.product_id,
                    product_name=p.product_name,
                    tax=p.tax,
                    rate=p.rate,
                    stock_quantity=p.stock_quantity
                };
                lst.Add(pr);
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }

        public JsonResult GetItem(int id)
        {
            //tbl_products t = db.tbl_products.Find(id);
            //t.tbl_invoice_products = null;

            tbl_products p = db.tbl_products.Find(id);
            
                tbl_products pr = new tbl_products()
                {
                    product_id = p.product_id,
                    product_name = p.product_name,
                    tax = p.tax,
                    rate = p.rate,
                    stock_quantity = p.stock_quantity
                    
                };
                


            return Json(pr, JsonRequestBehavior.AllowGet);
        }
    }
}