using System;
using System.Collections.Generic;
using System.Text;

namespace Coin.Domain.Models
{
    public class CoinType : Entity
    {
        public string Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
