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
        Invoice_DB db;
        public InvoiceController()
        {
            db = new Invoice_DB();
        }
        public ActionResult Index()
        {
            List<InvoiceModel> lst = GetAllInvoices();
            return View(lst);
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


        public ActionResult Pay(int id)
        {
            InvoiceModel m = GetAllInvoices().FirstOrDefault(e => e.invoice_id.Equals(id));
            ViewBag.invoice = m;
            tbl_invoice_payments p = new tbl_invoice_payments() { invoice_id = m.invoice_id };
            return View(p);
        }
        [HttpPost]
        public ActionResult Pay(tbl_invoice_payments p)
        {
            db.tbl_invoice_payments.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult ViewInvoice(int id)
        {
            tbl_invoice_details d = db.tbl_invoice_details.Find(id);
            return View(d);
        }


        public List<InvoiceModel> GetAllInvoices()
        {
            List<InvoiceModel> lst = new List<InvoiceModel>();
            List<tbl_invoice_details> invoices = db.tbl_invoice_details.ToList();
            foreach(tbl_invoice_details d in invoices)
            {
                List<tbl_invoice_payments> payments = db.tbl_invoice_payments.ToList().Where(e => e.invoice_id.Equals(d.invoice_id)).ToList();
                float totalamount = 0, paidamount = 0, remainingamount = 0;
                totalamount = (float)d.total_ammount;
                foreach(tbl_invoice_payments p in payments)
                {
                    paidamount += (float)p.payment_ammount;
                }
                remainingamount = totalamount - paidamount;
                string status = "";
                if(paidamount==0)
                {
                    status = "Un paid";
                }
                else if(paidamount>0 && paidamount<totalamount)
                {
                    status = "Partial Paid";
                }
                else if(paidamount==totalamount)
                {
                    status = "Paid";
                }

                InvoiceModel m = new InvoiceModel()
                {
                    invoice_id = d.invoice_id,
                    customer_id = (int)d.customer_id,
                    customer_name=d.tbl_customer.customer_name,
                    invoice_date=d.invoice_date,
                    paid_amount=paidamount,
                    remining_amount=remainingamount,
                    total_amount=totalamount,
                    status=status


                };
                lst.Add(m);
            }
            return lst;


        }

    }
}