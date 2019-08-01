using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class MarketService
    {
        public MarketService()
        {
            MarketServiceMapping = new HashSet<MarketServiceMapping>();
        }

        public long MarketServiceId { get; set; }
        public string MarketName { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<MarketServiceMapping> MarketServiceMapping { get; set; }
    }
}