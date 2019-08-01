using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class LengthFactorChannelMapping
    {
        public long MappingId { get; set; }
        public long LengthFactorId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public decimal RoundTo { get; set; }

        public virtual LocalLengthFactor LengthFactor { get; set; }
    }
}