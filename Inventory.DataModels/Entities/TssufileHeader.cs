using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssufileHeader
    {
        public int Id { get; set; }
        public string TssufileName { get; set; }
        public DateTime? FileDateTime { get; set; }
        public string RepCode { get; set; }
        public string StartBook { get; set; }
        public string EndBook { get; set; }
        public int? Dma { get; set; }
        public string Channel { get; set; }
        public string Playback { get; set; }
        public bool? IsNielsen { get; set; }
        public bool? IsComScore { get; set; }
        public bool? IsComment { get; set; }
        public bool? IsNotForSale { get; set; }
        public string GeneralInfo { get; set; }
        public bool? FileStatus { get; set; }
        public DateTime? ProcessDateTime { get; set; }
    }
}