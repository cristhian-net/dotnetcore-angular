using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dotnetcore.Models;
using dotnetcore.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dotnetcore.Controllers
{
    [Route("api/states")]
    public class StatesController
    {
        IRepository<State> _stateRepository;
        ILogger _logger;

        public StatesController(IRepository<State> stateRepository, ILoggerFactory loggerFactory)
        {
            _stateRepository = stateRepository;
            _logger = loggerFactory.CreateLogger(nameof(StatesController));
        }


    }
}