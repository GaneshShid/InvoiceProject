using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Invoice_Project_MVC.Models;
namespace Invoice_Project_MVC.Controllers
{
    public class InvoiceController : Controller
    {
        Invoice_DBEntities db;
        public InvoiceController()
        {
            db = new Invoice_DBEntities();
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult NewInvoice()
        {
            return View();
        }

        public string GenerateInvoice(tbl_invoice_details d)
        {
            db.tbl_invoice_details.Add(d);
            db.SaveChanges();
            return "Invoice generated succesfully";
        }
        

    }
}