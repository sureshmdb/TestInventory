using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssufileMaster
    {
        public int Id { get; set; }
        public int? HdrId { get; set; }
        public string TssufileMasterDescription { get; set; }
        public string StationCalls { get; set; }
        public string StationMedia { get; set; }
        public string Ssucode { get; set; }
        public int? SsudateCode { get; set; }
        public string SsustartDateTime { get; set; }
        public string Ssuenddate { get; set; }
        public string TssufileMasterTypes { get; set; }
        public string Dayparts { get; set; }
        public string ProgramTitle { get; set; }
        public string DayTime { get; set; }
        public string PrintDayTime { get; set; }
        public int? Ssuuid { get; set; }
        public bool? IsSsulocal { get; set; }
        public bool? IsAvailComments { get; set; }
        public bool? IsSsuforSale { get; set; }
        public string Ssuabbrev { get; set; }
        public int? NiprogramNumber { get; set; }
        public int? ComprogramNumber { get; set; }
        public int? MasterUid { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public DateTime? ProcessDateTime { get; set; }
    }
}