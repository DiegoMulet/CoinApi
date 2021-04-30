using Coin.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coin.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CoinsController : MainController
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Teste";
        }
    }
}
