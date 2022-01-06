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

        [ForeignKey("OperationTypes")]
        public int OperationTypeId { get;set;}
        public OperationTypes OperationType { get;set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get;set;}
    }
}
