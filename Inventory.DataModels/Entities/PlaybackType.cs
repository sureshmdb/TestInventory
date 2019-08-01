using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class PlaybackType
    {
        public string Id { get; set; }
        public string SourceName { get; set; }
        public int? RatingSourceId { get; set; }
        public string AlternativeId { get; set; }
        public string DisplayName { get; set; }
        public string DisplayId { get; set; }
        public int? SortOrder { get; set; }
    }
}