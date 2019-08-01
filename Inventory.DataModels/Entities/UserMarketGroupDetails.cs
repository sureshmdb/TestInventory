using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class UserMarketGroupDetails
    {
        public long MarketGroupId { get; set; }
        public long MdmmarketId { get; set; }

        public virtual UserMarketGroup MarketGroup { get; set; }
    }
}