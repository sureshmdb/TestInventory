using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramRate
    {
        public long Id { get; set; }
        public long RatecardId { get; set; }
        public long ProgramId { get; set; }
        public decimal RateFor30 { get; set; }
        public DateTime RateDate { get; set; }
        public decimal RoundTo { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool? IsNetwork { get; set; }

        public virtual Ratecard Ratecard { get; set; }
    }
}