using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Batch
    {
        public int Id { get; set; }
        public string BatchName { get; set; }
        public DateTime? LastPostDate { get; set; }
    }
}