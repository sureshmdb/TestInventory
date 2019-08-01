using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class UserTenantNetwork
    {
        public long UserNetworkId { get; set; }
        public long UserId { get; set; }
        public long? NetworkServiceId { get; set; }
    }
}