using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class SpecialMarketMapping
    {
        public long Id { get; set; }
        public long MarketId { get; set; }
        public long SpecialMarketId { get; set; }
    }
}