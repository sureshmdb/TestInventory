using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TbRatesBy
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool? Enable { get; set; }
    }
}