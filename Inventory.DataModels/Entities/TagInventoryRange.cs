using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TagInventoryRange
    {
        public long Id { get; set; }
        public long TagId { get; set; }
        public long? DaypartId { get; set; }

        public virtual Tag Tag { get; set; }
    }
}