using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Tokero.Interview.Data.Models;

namespace Tokero.Interview.Data
{
    public class OperationsDBContext : DbContext
    {
        public OperationsDBContext(DbContextOptions<OperationsDBContext> options) : base(options)
        {

        }

        public DbSet<OperationTypes> OperationTypes { get;set;}
        public DbSet<Deposits> Deposits { get;set;}
        public DbSet<Operations> Operations { get;set;}
        public DbSet<Withdrawals> Withdrawals { get;set;}
        public DbSet<TradeOrders> TradeOrders { get;set;}
        public DbSet<TradeOrderTypes> TradeOrderTypes { get;set;}

    }
}
