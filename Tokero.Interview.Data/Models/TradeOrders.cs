using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tokero.Interview.Data.Models
{
    public class TradeOrders
    {
        [Key]
        public int Id { get;set;}
        [ForeignKey("Operations")]
        public int OperationId { get; set; }
        public Operations Operations { get;set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get;set;}
        [ForeignKey("TradeOrderTypes")]
        public int TradeOrderTypeId { get;set;}
        public TradeOrderTypes TradeOrderTypes { get;set; }
    }
}
