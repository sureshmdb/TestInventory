using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class RateCardUsers
    {
        public long Id { get; set; }
        public long RatecardId { get; set; }
        public int UserId { get; set; }

        public virtual Ratecard Ratecard { get; set; }
    }
}