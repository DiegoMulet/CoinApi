using Coin.Api.Controllers;
using Coin.Application.Interfaces;
using Coin.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coin.Api.V1.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class CoinTypesController : MainController
    {
        private readonly ICoinTypeAppService _coinTypeAppService;

        public CoinTypesController(ICoinTypeAppService coinTypeAppService)
        {
            this._coinTypeAppService = coinTypeAppService;
        }

        /// <summary>
        /// Criar moedas
        /// </summary>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CoinType>>> GetAll()
        {
            var coinTypes = await _coinTypeAppService.GetAll();

            return coinTypes;
        }

        [HttpPost]
        public async Task<ActionResult<CoinType>> Add(CoinType coinType)
        {
            await _coinTypeAppService.Add(coinType);

            return Ok();
        }
    }
}
