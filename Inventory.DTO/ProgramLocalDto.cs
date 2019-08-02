using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory.DTO
{
    public class ProgramLocalDto
    {
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

    }
}
