using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class SpotLengthChannelMapping
    {
        public long Id { get; set; }
        public long SpotLengthId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public decimal? LengthFactor { get; set; }

        public virtual LocalSpotLength SpotLength { get; set; }
    }
}