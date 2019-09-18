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
    [Route("api/states")]
    public class StatesController : Controller
    {
        IRepository<State> _stateRepository;
        ILogger _logger;

        public StatesController(IRepository<State> stateRepository, ILoggerFactory loggerFactory)
        {
            _stateRepository = stateRepository;
            _logger = loggerFactory.CreateLogger(nameof(StatesController));
        }

        [HttpGet]
        [NoCache]
        [ProducesResponseType(typeof(List<State>), 200)]
        [ProducesResponseType(typeof(ApiResponse), 400)]
        public async Task<ActionResult> States()
        {
            try
            {
                var states = await _stateRepository.Filter();
                return Ok(states);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return BadRequest(new ApiResponse { Status = false });
            }
        }

    }
}