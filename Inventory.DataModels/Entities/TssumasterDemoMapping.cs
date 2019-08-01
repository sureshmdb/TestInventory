using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssumasterDemoMapping
    {
        public int MappingId { get; set; }
        public int? CampaignDemoId { get; set; }
        public string CampaignDemo { get; set; }
        public string Tssudemo { get; set; }
        public int? RatingSource { get; set; }
    }
}