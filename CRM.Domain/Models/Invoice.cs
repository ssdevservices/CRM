﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRM.Domain.Models
{
    [Table("Invoices", Schema = "dbo")]
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public int Amount { get; set; }

        public bool IsPaid { get; set; }

        public int FileId { get; set; }

        public File File { get; set; }
    }
}
