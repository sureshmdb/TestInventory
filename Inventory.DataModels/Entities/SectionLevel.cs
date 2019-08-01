using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class SectionLevel
    {
        public SectionLevel()
        {
            SectionChannelMapping = new HashSet<SectionChannelMapping>();
            SectionNetworkMapping = new HashSet<SectionNetworkMapping>();
        }

        public int SectionId { get; set; }
        public string SectionName { get; set; }
        public string SectionDescription { get; set; }
        public string Traffictranslator { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Sortorder { get; set; }
        public bool IsLocal { get; set; }
        public bool IsNetwork { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public bool? IsActive { get; set; }

        public virtual ICollection<SectionChannelMapping> SectionChannelMapping { get; set; }
        public virtual ICollection<SectionNetworkMapping> SectionNetworkMapping { get; set; }
    }
}