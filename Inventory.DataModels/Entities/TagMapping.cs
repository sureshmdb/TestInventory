using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TagMapping
    {
        public long TagId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public long Id { get; set; }
        public int? IsDelete { get; set; }

        public virtual Tag Tag { get; set; }
    }
}