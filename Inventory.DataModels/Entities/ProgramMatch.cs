using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramMatch
    {
        public ProgramMatch()
        {
            AutoBuildParameters = new HashSet<AutoBuildParameters>();
        }

        public long ProgramMatchId { get; set; }
        public string ProgramMatch1 { get; set; }

        public virtual ICollection<AutoBuildParameters> AutoBuildParameters { get; set; }
    }
}