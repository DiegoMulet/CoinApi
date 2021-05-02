using Coin.Application.Interfaces;
using Coin.Domain.Interfaces.Services;
using Coin.Domain.Models;
using Ons.Simons.Application;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coin.Application.Services
{    
    public class CoinTypeAppService : BaseAppService<CoinType>, ICoinTypeAppService
    {
        private readonly ICoinTypeService _coinTypeService;

        public CoinTypeAppService(ICoinTypeService coinTypeService)
            : base(coinTypeService)
        {
            this._coinTypeService = coinTypeService;
        }
    }
}
