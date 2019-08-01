using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssufileTrailer
    {
        public int Id { get; set; }
        public int? HdrId { get; set; }
        public string TssufileTrailerDescription { get; set; }
        public int? TotalRecords { get; set; }
        public string GeneralInfo { get; set; }
        public DateTime? ProcessDateTime { get; set; }
    }
}