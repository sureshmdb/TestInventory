using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class OrbitProgramNetwork
    {
        public long Id { get; set; }
        public string ProgramTitle { get; set; }
        public int? DaysId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public long ProgramId { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual ProgramNetwork Program { get; set; }
    }
}