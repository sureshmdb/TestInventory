using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramTagNetwork
    {
        public long Id { get; set; }
        public long ProgramId { get; set; }
        public long TagId { get; set; }
        public bool IsDelete { get; set; }

        public virtual ProgramNetwork Program { get; set; }
        public virtual Tag Tag { get; set; }
    }
}