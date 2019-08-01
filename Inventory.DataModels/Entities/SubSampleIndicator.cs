using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class SubSampleIndicator
    {
        public int Id { get; set; }
        public string SourceName { get; set; }
        public string SourceCode { get; set; }
        public int RatingSourceId { get; set; }
        public string DisplayName { get; set; }
    }
}