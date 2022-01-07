using System;
using System.Collections.Generic;
using System.Text;

namespace Tokero.Interview.Data.ViewModels
{
    public class WithdrawalVM
    {
        public decimal Amount { get;set;}
        public string ToAddress { get;set;}
        public bool TwoFactorEnabled { get;set;}
    }
}
