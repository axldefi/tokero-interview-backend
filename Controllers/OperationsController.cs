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
        [Route("get-all-by-type")]
        public IActionResult GetAllTradeOrders(int pageNumber, int pageSize)
        {
            try
            {
                var response = _operationsRepository.TradeOrdersGetAll(pageNumber, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("deposits")]
        public IActionResult GetAllDeposits(int pageNumber, int pageSize)
        {
            try
            {
                var response = _operationsRepository.DepositsGetAll(pageNumber, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("withdrawals")]
        public IActionResult GetAllWithdrawals(int pageNumber, int pageSize)
        {
            try
            {
                var response = _operationsRepository.WithdrawalsGetAll(pageNumber, pageSize);
                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
