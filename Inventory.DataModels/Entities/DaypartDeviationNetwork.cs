using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class DaypartDeviationNetwork
    {
        public int DaypartNetworkId { get; set; }
        public string DayPartDeviationName { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public int? DaysId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int Id { get; set; }
        public int? IsDelete { get; set; }
        public long? MdmnetworkId { get; set; }
    }
}