using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramHiatusLocal
    {
        public long Id { get; set; }
        public long ProgramId { get; set; }
        public DateTime? HiatusStartDate { get; set; }
        public DateTime? HiatusEndDate { get; set; }

        public virtual ProgramLocal Program { get; set; }
    }
}