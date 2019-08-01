using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class UserMarket
    {
        public long UserMarketId { get; set; }
        public long UserId { get; set; }
        public long MdmmarketId { get; set; }
        public int? MarketId { get; set; }

        public virtual Market Mdmmarket { get; set; }
        public virtual UserDetail User { get; set; }
    }
}