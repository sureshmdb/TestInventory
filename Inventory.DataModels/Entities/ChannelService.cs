using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ChannelService
    {
        public ChannelService()
        {
            ChannelServiceMapping = new HashSet<ChannelServiceMapping>();
        }

        public long ChannelServiceId { get; set; }
        public string ChannelName { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<ChannelServiceMapping> ChannelServiceMapping { get; set; }
    }
}