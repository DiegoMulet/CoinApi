using Coin.Domain.Interfaces.Repositorys;
using Coin.Domain.Interfaces.Services;
using Coin.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coin.Domain.Services
{
    public class CoinTypeService : BaseService<CoinType>, ICoinTypeService
    {
        private readonly ICoinTypeRepository _coinTypeRepository;

        public CoinTypeService(ICoinTypeRepository coinTypeRepository)
            : base(coinTypeRepository)
        {
            this._coinTypeRepository = coinTypeRepository;
        }
    }
}
