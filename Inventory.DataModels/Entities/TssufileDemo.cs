using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssufileDemo
    {
        public int Id { get; set; }
        public int? HdrId { get; set; }
        public string TssufileDemoDescription { get; set; }
        public string DemoList { get; set; }
        public DateTime? ProcessDateTime { get; set; }
    }
}