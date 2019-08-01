using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Ratecard
    {
        public Ratecard()
        {
            ProgramRate = new HashSet<ProgramRate>();
            RateCardChannelMapping = new HashSet<RateCardChannelMapping>();
            RateCardNetworkMapping = new HashSet<RateCardNetworkMapping>();
            RateCardUsers = new HashSet<RateCardUsers>();
        }

        public long RatecardId { get; set; }
        public string RatecardName { get; set; }
        public string RatecardDescription { get; set; }
        public bool IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Sortorder { get; set; }
        public bool? IsPrivate { get; set; }
        public int? SectionId { get; set; }
        public long? LengthfactorGroupId { get; set; }
        public long? CloneSourceId { get; set; }
        public bool IsLocal { get; set; }
        public bool IsNetwork { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public int? IndexValue { get; set; }
        public Guid ExternalIdentifier { get; set; }

        public virtual ICollection<ProgramRate> ProgramRate { get; set; }
        public virtual ICollection<RateCardChannelMapping> RateCardChannelMapping { get; set; }
        public virtual ICollection<RateCardNetworkMapping> RateCardNetworkMapping { get; set; }
        public virtual ICollection<RateCardUsers> RateCardUsers { get; set; }
    }
}