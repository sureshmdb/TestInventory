using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class SectionChannelMapping
    {
        public long Id { get; set; }
        public int SectionId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }

        public virtual SectionLevel Section { get; set; }
    }
}