using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class LocalLengthFactor
    {
        public LocalLengthFactor()
        {
            LengthFactorChannelMapping = new HashSet<LengthFactorChannelMapping>();
            LocalLengthFactorDeviation = new HashSet<LocalLengthFactorDeviation>();
            LocalLengthFactorSpots = new HashSet<LocalLengthFactorSpots>();
            LocalLengthFactorSpotsDeviation = new HashSet<LocalLengthFactorSpotsDeviation>();
        }

        public long LengthFactorId { get; set; }
        public string LengthFactorDescription { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public bool? IsCustom { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsActive { get; set; }
        public string GroupName { get; set; }
        public long? CloneSourceId { get; set; }

        public virtual ICollection<LengthFactorChannelMapping> LengthFactorChannelMapping { get; set; }
        public virtual ICollection<LocalLengthFactorDeviation> LocalLengthFactorDeviation { get; set; }
        public virtual ICollection<LocalLengthFactorSpots> LocalLengthFactorSpots { get; set; }
        public virtual ICollection<LocalLengthFactorSpotsDeviation> LocalLengthFactorSpotsDeviation { get; set; }
    }
}