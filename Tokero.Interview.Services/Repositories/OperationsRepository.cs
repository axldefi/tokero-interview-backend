using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tokero.Interview.Data;
using Tokero.Interview.Data.Models;
using Tokero.Interview.Data.ViewModels;
using Tokero.Interview.Services.Interfaces;
using Tokero.Interview.ViewModels;

namespace Tokero.Interview.Services.Repositories
{
    public class OperationsRepository : IOperationsRepository
    {
        readonly OperationsDBContext _dbContext;

        public OperationsRepository(OperationsDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<OperationTypes> OperationTypesGetAll()
        {
            return _dbContext.OperationTypes.ToList();
        }

        public List<TradeOrdersVM> TradeOrdersGetAll(int curPage, int pageNumber, int pageSize)
        {
            var result = _dbContext.TradeOrders
                .Include(x=> x.TradeOrderTypes)
                .Skip(pageSize * (curPage - 1))
                .Take(pageSize).ToList();
            var tradeOrders = new List<TradeOrdersVM>();
            foreach(var item in result)
            {
                var tradeOrder = new TradeOrdersVM()
                {
                    Amount = item.Amount,
                    TradeOrderType = item.TradeOrderTypes.Name
                };
                tradeOrders.Add(tradeOrder);
            }

            return tradeOrders;
        }

        public List<DepositsVM> DepositsGetAll(int curPage, int pageNumber, int pageSize)
        {
            var result = _dbContext.Deposits
                   .Skip(pageSize * (curPage - 1))
                   .Take(pageSize).ToList();
            var deposits = new List<DepositsVM>();
            foreach (var item in result)
            {
                var tradeOrder = new DepositsVM()
                {
                    Amount = item.Amount,
                    FromAddress = item.FromAddress,
                };
                deposits.Add(tradeOrder);
            }

            return deposits;
        }

        public List<WithdrawalVM> WithdrawalsGetAll(int curPage, int pageNumber, int pageSize)
        {
            var result = _dbContext.Withdrawals
                   .Skip(pageSize * (curPage - 1))
                   .Take(pageSize).ToList();
            var withdrawals = new List<WithdrawalVM>();
            foreach (var item in result)
            {
                var tradeOrder = new WithdrawalVM()
                {
                    Amount = item.Amount,
                    ToAddress = item.ToAddress,
                    TwoFactorEnabled = item.WasApprovedByUser2FA
                };
                withdrawals.Add(tradeOrder);
            }


            return withdrawals;
        }
    }
}
