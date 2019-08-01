using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TagSaleRange
    {
        public long TagId { get; set; }
        public bool? IsLocal { get; set; }
        public bool? IsNational { get; set; }
        public bool? IsNetwork { get; set; }
        public long Id { get; set; }

        public virtual Tag Tag { get; set; }
    }
}