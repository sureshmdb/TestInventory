using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class LocalSpotLength
    {
        public LocalSpotLength()
        {
            SpotLengthChannelMapping = new HashSet<SpotLengthChannelMapping>();
        }

        public long SpotLengthId { get; set; }
        public int SpotLength { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Sortorder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsCustom { get; set; }
        public decimal? LengthFactor { get; set; }

        public virtual ICollection<SpotLengthChannelMapping> SpotLengthChannelMapping { get; set; }
    }
}