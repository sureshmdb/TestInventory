using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ChannelServiceMapping
    {
        public long Id { get; set; }
        public long ChannelServiceId { get; set; }
        public int ChannelSourceId { get; set; }
        public int RatingSourceId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ChannelService ChannelService { get; set; }
    }
}