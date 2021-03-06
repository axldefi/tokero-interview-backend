using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tokero.Interview.Data.Models
{
    public class Withdrawals
    {
        [Key]
        public int Id { get;set;}
        [ForeignKey("Operations")]
        public int OperationId { get;set;}
        public Operations Operations { get;set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get;set;}
        public bool WasApprovedByUser2FA { get;set;}
        public string ToAddress { get;set;}
    }
}
