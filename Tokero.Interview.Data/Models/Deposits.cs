using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Tokero.Interview.Data.Models;

namespace Tokero.Interview.Data
{
    public class Deposits
    {
        [Key]
        public int Id { get;set;}
        public int OperationId { get;set;}
        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get;set;}
        public string FromAddress { get;set;}

    }
}
