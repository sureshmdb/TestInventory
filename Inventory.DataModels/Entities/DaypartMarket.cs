using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class DaypartMarket
    {
        public DaypartMarket()
        {
            DaypartDefinition = new HashSet<DaypartDefinition>();
            DaypartDeviation = new HashSet<DaypartDeviation>();
        }

        public int DaypartMarketId { get; set; }
        public long DaypartId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? MarketId { get; set; }
        public int? Sortorder { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? UpdatedBy { get; set; }
        public long? CreatedBy { get; set; }

        public virtual Daypart Daypart { get; set; }
        public virtual ICollection<DaypartDefinition> DaypartDefinition { get; set; }
        public virtual ICollection<DaypartDeviation> DaypartDeviation { get; set; }
    }
}