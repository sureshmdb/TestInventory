using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class DaypartDefinitionNetwork
    {
        public int DaypartNetworkId { get; set; }
        public string DayPartDefinitionName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? DaysId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Id { get; set; }
        public int? IsDelete { get; set; }
    }
}