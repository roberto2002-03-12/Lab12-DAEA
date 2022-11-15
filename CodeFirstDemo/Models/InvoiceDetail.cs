using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo.Models
{
    public class InvoiceDetail
    {
        public int InvoiceDetailId { get; set; }
        public string title { get; set; }
        public string description { get; set; }
    }
}