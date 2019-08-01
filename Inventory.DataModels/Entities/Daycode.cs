using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Daycode
    {
        public Daycode()
        {
            ProgramLocal = new HashSet<ProgramLocal>();
            ProgramNetwork = new HashSet<ProgramNetwork>();
        }

        public int DaysId { get; set; }
        public string DayCode1 { get; set; }
        public short? SortId { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsMo { get; set; }
        public bool IsTu { get; set; }
        public bool IsWe { get; set; }
        public bool IsTh { get; set; }
        public bool IsFr { get; set; }
        public bool IsSa { get; set; }
        public bool IsSu { get; set; }
        public bool? IsMoFr { get; set; }
        public int? DayCodeN { get; set; }
        public string Description { get; set; }
        public short FirstDay { get; set; }
        public short LastDay { get; set; }

        public virtual ICollection<ProgramLocal> ProgramLocal { get; set; }
        public virtual ICollection<ProgramNetwork> ProgramNetwork { get; set; }
    }
}