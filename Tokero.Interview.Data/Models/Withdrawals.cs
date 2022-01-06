using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tokero.Interview.Data.Models
{
    public class Withdrawals
    {
        [Key]
        public int Id { get;set;}
        public int OperationId { get;set;}
        public decimal Amount { get;set;}
        public bool WasApprovedByUser2FA { get;set;}
        public string ToAddress { get;set;}
    }
}
