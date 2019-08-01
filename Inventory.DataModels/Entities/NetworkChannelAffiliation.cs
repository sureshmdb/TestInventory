using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class NetworkChannelAffiliation
    {
        public long Id { get; set; }
        public long MdmnetworkId { get; set; }
        public long MdmchannelId { get; set; }
        public int? NetworkAffiliationRank { get; set; }
    }
}