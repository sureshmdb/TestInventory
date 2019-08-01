using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssufileDemoTrack
    {
        public int Id { get; set; }
        public int? HdrId { get; set; }
        public int? MstId { get; set; }
        public string TssufileDemoTrackDescription { get; set; }
        public string Book { get; set; }
        public byte? TssufileDemoType { get; set; }
        public byte? Home { get; set; }
        public int? Market { get; set; }
        public bool? IsParentOnly { get; set; }
        public bool? IsExclusion { get; set; }
        public bool? IsAlternate { get; set; }
        public bool? IsSpecialEval { get; set; }
        public string TimeShift { get; set; }
        public int? ClusterId { get; set; }
        public string SubType { get; set; }
        public string SubTypeValue { get; set; }
        public string FootNote { get; set; }
        public string Programming { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public DateTime? ProcessDateTime { get; set; }
    }
}