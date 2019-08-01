using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramDaypartLocal
    {
        public long Id { get; set; }
        public long ProgramId { get; set; }
        public long DaypartId { get; set; }
        public bool IsDelete { get; set; }
        public int? SortOrder { get; set; }

        public virtual Daypart Daypart { get; set; }
        public virtual ProgramLocal Program { get; set; }
    }
}