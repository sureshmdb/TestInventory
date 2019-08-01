using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class UserChannel
    {
        public long UserChannelId { get; set; }
        public long UserId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public int? IsDeleted { get; set; }

        public virtual Channel Mdmchannel { get; set; }
        public virtual UserDetail User { get; set; }
    }
}