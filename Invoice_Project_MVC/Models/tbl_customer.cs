//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Invoice_Project_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_customer
    {
        public int customer_id { get; set; }
        public Nullable<int> invoice_id { get; set; }
        public string customer_name { get; set; }
        public string email_address { get; set; }
        public string mobile_number { get; set; }
        public string city { get; set; }
    
        public virtual tbl_invoice_details tbl_invoice_details { get; set; }
    }
}