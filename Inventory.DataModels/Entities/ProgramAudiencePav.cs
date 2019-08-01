using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramAudiencePav
    {
        public long PavId { get; set; }
        public long ProgramAudienceId { get; set; }
        public long ProgramId { get; set; }
        public string ProgramTitle { get; set; }
        public string Weeks { get; set; }
        public string Days { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Avg { get; set; }
        public string Rating { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public string ChannelName { get; set; }
        public long? MdmchannelId { get; set; }
        public int? ChannelSourceId { get; set; }
        public string SurveyName { get; set; }

        public virtual ProgramAudience ProgramAudience { get; set; }
    }
}