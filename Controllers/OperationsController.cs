using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tokero.Interview.Services.Interfaces;

namespace Tokero.Interview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OperationsController : ControllerBase
    {
        private readonly IOperationsRepository _operationsRepository;
        public OperationsController(IOperationsRepository operationsRepository)
        {
            _operationsRepository = operationsRepository;
        }

        [HttpGet]
        [Route("operation-types")]
        public IActionResult GetAllOperationTypes()
        {
            try
            {
                var response = _operationsRepository.OperationTypesGetAll();
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("table-data")]
        public IActionResult GetTableData(int type, int curPage, int pageNumber, int pageSize)
        {
            
            curPage = 1;
            pageNumber = 1;
            pageSize = 5;
            try
            {
                if (type == 1)
                {
                    var response = _operationsRepository.DepositsGetAll(curPage, pageNumber, pageSize);
                    return Ok(response);
                }
                if(type == 2)
                {
                    var response = _operationsRepository.WithdrawalsGetAll(curPage, pageNumber, pageSize);
                    return Ok(response);
                }
                if(type == 3)
                {
                    var response = _operationsRepository.TradeOrdersGetAll(curPage, pageNumber, pageSize);
                    return Ok(response);
                }
                return BadRequest();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
