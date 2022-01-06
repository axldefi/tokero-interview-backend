using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Tokero.Interview.Data.Models
{
    public class Operations
    {
        [Key]
        public int Id { get;set;}

        public int OperationTypeId { get;set;}
        public decimal Amount { get;set;}
    }
}
