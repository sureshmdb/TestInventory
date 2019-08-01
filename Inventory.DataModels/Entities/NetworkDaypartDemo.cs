using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class NetworkDaypartDemo
    {
        public int Id { get; set; }
        public long NetworkId { get; set; }
        public long DaypartId { get; set; }
        public long DemoId { get; set; }
        public int RatingSourceId { get; set; }
        public long UserId { get; set; }

        public virtual Daypart Daypart { get; set; }
    }
}