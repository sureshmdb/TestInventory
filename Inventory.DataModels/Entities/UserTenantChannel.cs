using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class UserTenantChannel
    {
        public long UserChannelId { get; set; }
        public long UserId { get; set; }
        public long? ChannelServiceId { get; set; }
    }
}