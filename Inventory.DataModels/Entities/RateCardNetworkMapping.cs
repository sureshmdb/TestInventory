using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class RateCardNetworkMapping
    {
        public long Id { get; set; }
        public long RatecardId { get; set; }
        public long MdmnetworkId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }

        public virtual Ratecard Ratecard { get; set; }
    }
}