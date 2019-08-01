using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class DaypartDefinition
    {
        public int DaypartMarketId { get; set; }
        public string DayPartDefinitionName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? DaysId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public bool? IsLocal { get; set; }
        public bool? IsNetwork { get; set; }
        public int Id { get; set; }
        public int? IsDelete { get; set; }

        public virtual DaypartMarket DaypartMarket { get; set; }
    }
}