using System;
using System.Collections.Generic;
using System.Text;
using Tokero.Interview.Data;
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
    }
}
