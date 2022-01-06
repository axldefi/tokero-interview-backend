using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.ComponentModel.DataAnnotations;
using Tokero.Interview.Data.Models;

namespace Tokero.Interview.Data
{
    public class Deposits
    {
        [Key]
        public int Id { get;set;}
        public int OperationId { get;set;}
        public decimal Amount { get;set;}
        public string FromAddress { get;set;}

    }
}
