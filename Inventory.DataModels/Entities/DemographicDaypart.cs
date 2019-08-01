using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class DemographicDaypart
    {
        public long DemographicId { get; set; }
        public string Name { get; set; }
        public int RatingSourceId { get; set; }
        public int SourceId { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
    }
}