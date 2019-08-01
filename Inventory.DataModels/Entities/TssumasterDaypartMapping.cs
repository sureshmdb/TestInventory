using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssumasterDaypartMapping
    {
        public int MappingId { get; set; }
        public int? CampaignDaypartId { get; set; }
        public string CampaignDaypart { get; set; }
        public string Ssudaypart { get; set; }
    }
}