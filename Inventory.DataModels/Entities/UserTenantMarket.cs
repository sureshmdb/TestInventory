using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class UserTenantMarket
    {
        public long UserMarketId { get; set; }
        public long UserId { get; set; }
        public long? MarketServiceId { get; set; }
    }
}