﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NetKeites.Messages;

namespace NetKeites.Store.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : ControllerBase
    {
        private readonly ILogger<StoreController> _logger;

        public StoreController(ILogger<StoreController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("Products{productId}")]
        public IEnumerable<ProductAggregate> Get(int productId)
        {
            return new List<ProductAggregate>();
        }
    }
}
