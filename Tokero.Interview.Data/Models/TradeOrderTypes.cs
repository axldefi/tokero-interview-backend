using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tokero.Interview.Data.Models
{
    public class TradeOrderTypes
    {
        [Key]
        public int Id { get;set; }
        public string Name { get;set; }
    }
}
