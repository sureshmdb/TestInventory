using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TenantMarket
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public long MarketServiceId { get; set; }

        public virtual Tenant Tenant { get; set; }
    }
}