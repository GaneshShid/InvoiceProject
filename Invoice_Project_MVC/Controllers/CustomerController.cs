using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invoice_Project_MVC.Models;
namespace Invoice_Project_MVC.Controllers
{
    public class CustomerController : Controller
    {
        Invoice_DBEntities db;
        public CustomerController()
        {
            db = new Invoice_DBEntities();
        }
        
        public JsonResult GetCustomers()
        {
            List<tbl_customer> lst = new List<tbl_customer>();
            foreach(tbl_customer c in db.tbl_customer.ToList())
            {
                tbl_customer tc = new tbl_customer() {
                    customer_id = c.customer_id,
                    customer_name = c.customer_name,
                    city = c.city,
                    email_address=c.email_address,
                    mobile_number = c.mobile_number,
                };
                lst.Add(tc);
            }
            return Json(lst, JsonRequestBehavior.AllowGet);
        }
    }
}