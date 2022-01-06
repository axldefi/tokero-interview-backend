using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tokero.Interview.Data.Models
{
    public class TradeOrders
    {
        [Key]
        public int Id { get;set;}
        public int OperationId { get; set; }
        public decimal Amount { get;set;}
        public int TradeOrderTypeId { get;set;}
    }
}
