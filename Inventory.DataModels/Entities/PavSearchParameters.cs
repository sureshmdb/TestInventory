using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class PavSearchParameters
    {
        public long Id { get; set; }
        public long ProgramAudienceId { get; set; }
        public string MdmchannelId { get; set; }
        public int DaysId { get; set; }
        public string Surveys { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Title { get; set; }
        public int SampleId { get; set; }
        public string PlaybackId { get; set; }
        public string ProgramAveragePeriod { get; set; }
        public int? WeekId { get; set; }
    }
}