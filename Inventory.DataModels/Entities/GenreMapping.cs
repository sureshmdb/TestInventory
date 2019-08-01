using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class GenreMapping
    {
        public long GenreId { get; set; }
        public long MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public long Id { get; set; }
        public int? IsDelete { get; set; }

        public virtual Genre Genre { get; set; }
    }
}