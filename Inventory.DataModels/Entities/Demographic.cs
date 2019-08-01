using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Demographic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RatingSource { get; set; }
        public string SourceName { get; set; }
        public int Category { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int Oid { get; set; }
        public int? Tag { get; set; }
        public string AltSourceName { get; set; }
    }
}