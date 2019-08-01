using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class RoundFactor
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Display { get; set; }
        public decimal Value { get; set; }
        public int SortOrder { get; set; }
    }
}