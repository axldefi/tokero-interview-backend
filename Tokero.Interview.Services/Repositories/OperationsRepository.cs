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

        public List<TradeOrders> TradeOrdersGetAll(int pageNumber, int pageSize)
        {
            return _dbContext.TradeOrders.ToList();
        }
        public List<Deposits> DepositsGetAll(int pageNumber, int pageSize)
        {
            return _dbContext.Deposits.ToList();
        }

        public List<Withdrawals> WithdrawalsGetAll(int pageNumber, int pageSize)
        {
            return _dbContext.Withdrawals.ToList();
        }
    }
}
