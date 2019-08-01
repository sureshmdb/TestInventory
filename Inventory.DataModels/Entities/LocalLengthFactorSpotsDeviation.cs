using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class LocalLengthFactorSpotsDeviation
    {
        public long Id { get; set; }
        public long MappingId { get; set; }
        public long SpotLengthId { get; set; }
        public decimal? LengthFactor { get; set; }
        public long? LengthFactorId { get; set; }

        public virtual LocalLengthFactor LengthFactorNavigation { get; set; }
    }
}