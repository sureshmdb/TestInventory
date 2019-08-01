using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ComscoreSweepDates
    {
        public int Id { get; set; }
        public string SweepName { get; set; }
        public short? SweepYear { get; set; }
        public short? SweepMonth { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }
    }
}