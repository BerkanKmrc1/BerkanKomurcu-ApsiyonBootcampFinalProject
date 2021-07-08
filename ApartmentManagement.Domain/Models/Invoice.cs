using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagement.Domain.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string InvoiceName { get; set; }
        public string InvoiceNo  { get; set; }
        public DateTime InvoiceDate  { get; set; }
        public string InvoiceAmount  { get; set; }
        public  Housing Housing{ get; set; }// bir fatura sadece bir dairee ait olabilir
    }
}
