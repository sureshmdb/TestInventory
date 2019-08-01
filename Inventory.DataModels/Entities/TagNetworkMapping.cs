using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TagNetworkMapping
    {
        public long TagId { get; set; }
        public long MdmnetworkId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public bool IsDelete { get; set; }
        public long Id { get; set; }

        public virtual Tag Tag { get; set; }
    }
}