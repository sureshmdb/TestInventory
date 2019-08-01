using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class NetworkServiceMapping
    {
        public long Id { get; set; }
        public long NetworkServiceId { get; set; }
        public int NetworkSourceId { get; set; }
        public int RatingSourceId { get; set; }
        public bool IsDeleted { get; set; }

        public virtual NetworkService NetworkService { get; set; }
    }
}