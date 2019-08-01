using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramLocal
    {
        public ProgramLocal()
        {
            OrbitProgramLocal = new HashSet<OrbitProgramLocal>();
            ProgramDaypartLocal = new HashSet<ProgramDaypartLocal>();
            ProgramGenreLocal = new HashSet<ProgramGenreLocal>();
            ProgramHiatusLocal = new HashSet<ProgramHiatusLocal>();
            ProgramTagLocal = new HashSet<ProgramTagLocal>();
        }

        public long ProgramId { get; set; }
        public string ProgramTitle { get; set; }
        public string ProgramDescription { get; set; }
        public int DaysId { get; set; }
        public string TranslationId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string Comment { get; set; }
        public bool? IsAutoPav { get; set; }
        public byte IsActive { get; set; }
        public byte IsHiatus { get; set; }
        public byte IsDelete { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public long? NetworkProgramId { get; set; }
        public string RatingSource { get; set; }
        public int MarketId { get; set; }
        public long MdmchannelId { get; set; }
        public bool? IsLock { get; set; }
        public long? ProgramSourceId { get; set; }
        public bool? IsCombo { get; set; }
        public string Ssucode { get; set; }
        public bool ChildLock { get; set; }
        public Guid ExternalIdentifier { get; set; }

        public virtual Daycode Days { get; set; }
        public virtual ICollection<OrbitProgramLocal> OrbitProgramLocal { get; set; }
        public virtual ICollection<ProgramDaypartLocal> ProgramDaypartLocal { get; set; }
        public virtual ICollection<ProgramGenreLocal> ProgramGenreLocal { get; set; }
        public virtual ICollection<ProgramHiatusLocal> ProgramHiatusLocal { get; set; }
        public virtual ICollection<ProgramTagLocal> ProgramTagLocal { get; set; }
    }
}