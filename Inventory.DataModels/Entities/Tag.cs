using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Tag
    {
        public Tag()
        {
            ProgramTagLocal = new HashSet<ProgramTagLocal>();
            ProgramTagNetwork = new HashSet<ProgramTagNetwork>();
            TagInventoryRange = new HashSet<TagInventoryRange>();
            TagMapping = new HashSet<TagMapping>();
            TagNetworkMapping = new HashSet<TagNetworkMapping>();
        }

        public long TagId { get; set; }
        public string TagName { get; set; }
        public string TagDescription { get; set; }
        public int? IsDelete { get; set; }
        public int? Sortorder { get; set; }
        public int? ParentRange { get; set; }
        public long? CloneSourceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool IsNetwork { get; set; }
        public long? NetworkTagId { get; set; }

        public virtual TagSaleRange TagSaleRange { get; set; }
        public virtual ICollection<ProgramTagLocal> ProgramTagLocal { get; set; }
        public virtual ICollection<ProgramTagNetwork> ProgramTagNetwork { get; set; }
        public virtual ICollection<TagInventoryRange> TagInventoryRange { get; set; }
        public virtual ICollection<TagMapping> TagMapping { get; set; }
        public virtual ICollection<TagNetworkMapping> TagNetworkMapping { get; set; }
    }
}