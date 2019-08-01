using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class GenreSaleRange
    {
        public long GenreId { get; set; }
        public bool? IsLocal { get; set; }
        public bool? IsNational { get; set; }
        public bool? IsNetwork { get; set; }
        public long Id { get; set; }

        public virtual Genre Genre { get; set; }
    }
}