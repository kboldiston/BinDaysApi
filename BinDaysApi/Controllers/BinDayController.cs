using BinDaysApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BinDaysApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BinDayController : ControllerBase
    {
        private readonly ILogger<BinDayController> _logger;

        public BinDayController(ILogger<BinDayController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public BinData Get(long latitude, long longtitude)
        {
            return new BinData();
        }

        [HttpGet]
        public IEnumerable<BinData> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new BinData
            {
                Date = DateTime.Now.AddDays(index),
                Type = BinTypes.GeneralWaste
            })
            .ToArray();
        }
    }
}
