using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Daypart
    {
        public Daypart()
        {
            DaypartDemo = new HashSet<DaypartDemo>();
            DaypartMarket = new HashSet<DaypartMarket>();
            NetworkDaypartDemo = new HashSet<NetworkDaypartDemo>();
            ProgramDaypartLocal = new HashSet<ProgramDaypartLocal>();
            ProgramDaypartNetwork = new HashSet<ProgramDaypartNetwork>();
        }

        public long DaypartId { get; set; }
        public string DaypartCode { get; set; }
        public string DaypartName { get; set; }
        public string DaypartDescription { get; set; }
        public int? Sortorder { get; set; }
        public DateTime? CreatedDate { get; set; }

        public virtual ICollection<DaypartDemo> DaypartDemo { get; set; }
        public virtual ICollection<DaypartMarket> DaypartMarket { get; set; }
        public virtual ICollection<NetworkDaypartDemo> NetworkDaypartDemo { get; set; }
        public virtual ICollection<ProgramDaypartLocal> ProgramDaypartLocal { get; set; }
        public virtual ICollection<ProgramDaypartNetwork> ProgramDaypartNetwork { get; set; }
    }
}