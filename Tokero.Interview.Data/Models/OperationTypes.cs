using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Tokero.Interview.Data.Models
{
    public class OperationTypes
    {
        [Key]
        public int Id { get;set;}
        [Required]
        public string Name { get;set;}
    }
}
