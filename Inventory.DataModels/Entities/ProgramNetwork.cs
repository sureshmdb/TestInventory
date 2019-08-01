using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramNetwork
    {
        public ProgramNetwork()
        {
            OrbitProgramNetwork = new HashSet<OrbitProgramNetwork>();
            ProgramDaypartNetwork = new HashSet<ProgramDaypartNetwork>();
            ProgramGenreNetwork = new HashSet<ProgramGenreNetwork>();
            ProgramHiatusNetwork = new HashSet<ProgramHiatusNetwork>();
            ProgramTagNetwork = new HashSet<ProgramTagNetwork>();
        }

        public long ProgramId { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramDescription { get; set; }
        public int? DaysId { get; set; }
        public string TranslationId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public bool? IsLive { get; set; }
        public string TimeZone { get; set; }
        public string Comment { get; set; }
        public bool? IsAutoPav { get; set; }
        public string RatingSource { get; set; }
        public byte IsActive { get; set; }
        public byte IsHiatus { get; set; }
        public byte IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public long MdmnetworkId { get; set; }
        public bool? IsLock { get; set; }
        public long? ProgramSourceId { get; set; }
        public bool? IsCombo { get; set; }
        public Guid ExternalIdentifier { get; set; }

        public virtual Daycode Days { get; set; }
        public virtual ICollection<OrbitProgramNetwork> OrbitProgramNetwork { get; set; }
        public virtual ICollection<ProgramDaypartNetwork> ProgramDaypartNetwork { get; set; }
        public virtual ICollection<ProgramGenreNetwork> ProgramGenreNetwork { get; set; }
        public virtual ICollection<ProgramHiatusNetwork> ProgramHiatusNetwork { get; set; }
        public virtual ICollection<ProgramTagNetwork> ProgramTagNetwork { get; set; }
    }
}