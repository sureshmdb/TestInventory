using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class MarketChannelAffiliation
    {
        public long Id { get; set; }
        public int MarketSourceId { get; set; }
        public long MdmchannelId { get; set; }
        public int? IsMarketOfOrigin { get; set; }
    }
}