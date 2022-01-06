using System;
using System.Collections.Generic;
using System.Text;
using Tokero.Interview.Data;
using Tokero.Interview.Data.Models;

namespace Tokero.Interview.Services.Interfaces
{
    public interface IOperationsRepository
    {
        List<OperationTypes> OperationTypesGetAll();
        List<TradeOrders> TradeOrdersGetAll(int curPage, int pageNumber, int pageSize);
        List<Withdrawals> WithdrawalsGetAll(int curPage, int pageNumber, int pageSize);
        List<Deposits> DepositsGetAll(int curPage, int pageNumber, int pageSize);
    }
}
