using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class GenreInventoryRange
    {
        public long Id { get; set; }
        public long GenreId { get; set; }
        public long? DaypartId { get; set; }

        public virtual Genre Genre { get; set; }
    }
}