using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class NetworkSpotLength
    {
        public NetworkSpotLength()
        {
            SpotLengthNetworkMapping = new HashSet<SpotLengthNetworkMapping>();
        }

        public long SpotLengthId { get; set; }
        public int SpotLength { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Sortorder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsCustom { get; set; }
        public decimal? LengthFactor { get; set; }

        public virtual ICollection<SpotLengthNetworkMapping> SpotLengthNetworkMapping { get; set; }
    }
}