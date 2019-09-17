using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetcore.Infrastructure;
using dotnetcore.Models;
using dotnetcore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetcore.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        ICustomerRepository _customerRepository;
        ILogger _logger;

        public CustomersController(ICustomerRepository customerRepository, ILoggerFactory loggerFactory)
        {
            _customerRepository = customerRepository;
            _logger = loggerFactory.CreateLogger(nameof(CustomersController));
        }

        [HttpGet]
        [NoCache]
        [ProducesResponseType(typeof(List<Customer>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> Customers()
        {
            try
            {
                var customers = await _customerRepository.GetCustomersWithState();
                return Ok(customers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }
    }
}