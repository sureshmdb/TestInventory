using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class AutoBuildParameters
    {
        public long Id { get; set; }
        public long ProgramMatchId { get; set; }
        public long AverageById { get; set; }
        public string RatingSourceId { get; set; }
        public long DominantAssignId { get; set; }
        public long NonDominantAssignId { get; set; }
        public bool IgnoreOneTimeOnly { get; set; }
        public int? WeeksId { get; set; }
        public DateTime CreatedDate { get; set; }
        public long CreatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public long UpdatedBy { get; set; }

        public virtual AverageBy AverageBy { get; set; }
        public virtual ProgramMatch ProgramMatch { get; set; }
    }
}