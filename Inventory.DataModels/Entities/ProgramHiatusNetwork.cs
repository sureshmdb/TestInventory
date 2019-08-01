using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramHiatusNetwork
    {
        public long Id { get; set; }
        public long ProgramId { get; set; }
        public DateTime? HiatusStartDate { get; set; }
        public DateTime? HiatusEndDate { get; set; }

        public virtual ProgramNetwork Program { get; set; }
    }
}