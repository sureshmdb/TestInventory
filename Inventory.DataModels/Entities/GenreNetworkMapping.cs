using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class GenreNetworkMapping
    {
        public long GenreId { get; set; }
        public long MdmnetworkId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public bool IsDelete { get; set; }
        public long Id { get; set; }

        public virtual Genre Genre { get; set; }
    }
}