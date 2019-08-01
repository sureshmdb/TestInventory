using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class DaypartNetwork
    {
        public long DaypartNetworkId { get; set; }
        public long DaypartId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? Sortorder { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public long? CreatedBy { get; set; }
        public long? MdmnetworkId { get; set; }
    }
}