using Coin.Data.Context;
using Coin.Domain.Interfaces.Repositorys;
using Coin.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Coin.Data.Repository
{
    public class CoinTypeRepository : Repository<CoinType>, ICoinTypeRepository
    {
        private readonly CoinDbContext _coinDbContext;

        public CoinTypeRepository(CoinDbContext coinDbContext)
            : base (coinDbContext)
        {
            this._coinDbContext = coinDbContext;
        }
    }
}
