using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class UserMarketGroup
    {
        public UserMarketGroup()
        {
            UserMarketGroupDetails = new HashSet<UserMarketGroupDetails>();
        }

        public long MarketGroupId { get; set; }
        public string MarketGroupName { get; set; }

        public virtual ICollection<UserMarketGroupDetails> UserMarketGroupDetails { get; set; }
    }
}