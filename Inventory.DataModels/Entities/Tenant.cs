using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Tenant
    {
        public Tenant()
        {
            TenantMarket = new HashSet<TenantMarket>();
            TenantNetwork = new HashSet<TenantNetwork>();
        }

        public int TenantId { get; set; }
        public string TenantName { get; set; }

        public virtual ICollection<TenantMarket> TenantMarket { get; set; }
        public virtual ICollection<TenantNetwork> TenantNetwork { get; set; }
    }
}