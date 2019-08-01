using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class MarketServiceMapping
    {
        public long Id { get; set; }
        public long MarketServiceId { get; set; }
        public int MarketSourceId { get; set; }
        public int RatingSourceId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual MarketService MarketService { get; set; }
    }
}