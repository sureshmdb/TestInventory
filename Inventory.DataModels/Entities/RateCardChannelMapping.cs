using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class RateCardChannelMapping
    {
        public long Id { get; set; }
        public long RatecardId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }

        public virtual Ratecard Ratecard { get; set; }
    }
}