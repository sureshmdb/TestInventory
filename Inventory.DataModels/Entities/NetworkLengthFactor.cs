using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class NetworkLengthFactor
    {
        public NetworkLengthFactor()
        {
            LengthFactorNetworkMapping = new HashSet<LengthFactorNetworkMapping>();
            NetworkLengthFactorDeviation = new HashSet<NetworkLengthFactorDeviation>();
            NetworkLengthFactorSpots = new HashSet<NetworkLengthFactorSpots>();
            NetworkLengthFactorSpotsDeviation = new HashSet<NetworkLengthFactorSpotsDeviation>();
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

        public virtual ICollection<LengthFactorNetworkMapping> LengthFactorNetworkMapping { get; set; }
        public virtual ICollection<NetworkLengthFactorDeviation> NetworkLengthFactorDeviation { get; set; }
        public virtual ICollection<NetworkLengthFactorSpots> NetworkLengthFactorSpots { get; set; }
        public virtual ICollection<NetworkLengthFactorSpotsDeviation> NetworkLengthFactorSpotsDeviation { get; set; }
    }
}