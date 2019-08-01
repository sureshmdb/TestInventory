using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssufileConfig
    {
        public int Id { get; set; }
        public string TssufileConfigDescription { get; set; }
        public string TssufileConfigVersion { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}