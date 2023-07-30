using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Invoice_Project_MVC.Models;
namespace Invoice_Project_MVC.Models
{
    public class InvoiceModel
    {
        public int invoice_id { get; set; }
        public int customer_id { get; set; }
        public string customer_name { get; set; }
        public string invoice_date { get; set; }
        public float  total_amount { get; set; }
        public float  paid_amount { get; set; }
        public float  remining_amount { get; set; }
        public string status { get; set; }

    }
}