using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int CustomerID { get; set; }
        public int CampaignID { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime DueDate { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TaxAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public decimal PaidAmount { get; set; }
        public decimal BalanceAmount { get; set; }
        public string Status { get; set; } // Draft, Sent, Paid, Overdue, Cancelled
        public string PaymentMethod { get; set; } // Credit Card, Bank Transfer, PayPal, Cash
        public DateTime? PaymentDate { get; set; }
        public string BillingPeriodStart { get; set; }
        public string BillingPeriodEnd { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedOn { get; set; }

        public Customer Customer { get; set; }
        public Campaign Campaign { get; set; }
    }
}
