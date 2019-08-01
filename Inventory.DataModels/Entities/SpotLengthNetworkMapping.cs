using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class SpotLengthNetworkMapping
    {
        public long Id { get; set; }
        public long SpotLengthId { get; set; }
        public long MdmnetworkId { get; set; }
        public decimal? LengthFactor { get; set; }

        public virtual NetworkSpotLength SpotLength { get; set; }
    }
}