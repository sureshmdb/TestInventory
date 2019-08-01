using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramAudience
    {
        public ProgramAudience()
        {
            ProgramAudiencePav = new HashSet<ProgramAudiencePav>();
        }

        public long Id { get; set; }
        public string SurveyName { get; set; }
        public int? MarketId { get; set; }
        public long? MdmchannelId { get; set; }
        public long? ProgramId { get; set; }
        public int? RatingSourceId { get; set; }
        public string Rating { get; set; }
        public string Type { get; set; }
        public long? MdmmarketId { get; set; }
        public int? BookType { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public bool IsImpact { get; set; }
        public string Rationale { get; set; }
        public bool? IsCopyPlayback { get; set; }

        public virtual ICollection<ProgramAudiencePav> ProgramAudiencePav { get; set; }
    }
}