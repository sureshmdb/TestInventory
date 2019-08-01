using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class AverageBy
    {
        public AverageBy()
        {
            AutoBuildParameters = new HashSet<AutoBuildParameters>();
        }

        public long AverageById { get; set; }
        public string AverageBy1 { get; set; }

        public virtual ICollection<AutoBuildParameters> AutoBuildParameters { get; set; }
    }
}