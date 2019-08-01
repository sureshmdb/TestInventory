using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class LengthFactorNetworkMapping
    {
        public long MappingId { get; set; }
        public long LengthFactorId { get; set; }
        public long MdmnetworkId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public decimal RoundTo { get; set; }

        public virtual NetworkLengthFactor LengthFactor { get; set; }
    }
}