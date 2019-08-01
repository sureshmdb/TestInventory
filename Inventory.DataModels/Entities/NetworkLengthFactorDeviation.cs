using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class NetworkLengthFactorDeviation
    {
        public long Id { get; set; }
        public long LengthFactorId { get; set; }
        public long MappingId { get; set; }
        public long DaypartId { get; set; }
        public long TagId { get; set; }
        public decimal? RoundTo { get; set; }

        public virtual NetworkLengthFactor LengthFactor { get; set; }
    }
}