using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TenantChannel
    {
        public int Id { get; set; }
        public int TenantId { get; set; }
        public long ChannelServiceId { get; set; }
    }
}