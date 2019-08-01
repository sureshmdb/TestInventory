using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class DaypartDemo
    {
        public int Id { get; set; }
        public int MarketId { get; set; }
        public long DaypartId { get; set; }
        public long DemoId { get; set; }
        public int RatingSourceId { get; set; }
        public long UserId { get; set; }

        public virtual Daypart Daypart { get; set; }
    }
}