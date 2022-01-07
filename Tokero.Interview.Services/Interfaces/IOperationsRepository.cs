using System;
using System.Collections.Generic;
using System.Text;
using Tokero.Interview.Data;
using Tokero.Interview.Data.Models;
using Tokero.Interview.Data.ViewModels;
using Tokero.Interview.ViewModels;

namespace Tokero.Interview.Services.Interfaces
{
    public interface IOperationsRepository
    {
        List<OperationTypes> OperationTypesGetAll();
        List<TradeOrdersVM> TradeOrdersGetAll(int curPage, int pageNumber, int pageSize);
        List<WithdrawalVM> WithdrawalsGetAll(int curPage, int pageNumber, int pageSize);
        List<DepositsVM> DepositsGetAll(int curPage, int pageNumber, int pageSize);
    }
}
