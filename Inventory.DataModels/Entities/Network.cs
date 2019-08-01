using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Network
    {
        public long MdmnetworkId { get; set; }
        public int? RatingSourceId { get; set; }
        public string LongName { get; set; }
        public string ShortName { get; set; }
        public byte? AdminUnderwriteId { get; set; }
    }
}