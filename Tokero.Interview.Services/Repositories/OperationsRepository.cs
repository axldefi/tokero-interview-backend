using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tokero.Interview.Data;
using Tokero.Interview.Data.Models;
using Tokero.Interview.Services.Interfaces;

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

        public List<TradeOrders> TradeOrdersGetAll(int curPage, int pageNumber, int pageSize)
        {

            return _dbContext.TradeOrders.Skip(pageSize * (curPage - 1)).Take(pageSize).ToList();
        }
        public List<Deposits> DepositsGetAll(int curPage, int pageNumber, int pageSize)
        {
            return _dbContext.Deposits.Skip(pageSize * (curPage - 1)).Take(pageSize).ToList();
        }

        public List<Withdrawals> WithdrawalsGetAll(int curPage, int pageNumber, int pageSize)
        {
            return _dbContext.Withdrawals.Skip(pageSize * (curPage - 1)).Take(pageSize).ToList();
        }
    }
}
