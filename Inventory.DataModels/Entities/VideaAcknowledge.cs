using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class VideaAcknowledge
    {
        public long Id { get; set; }
        public string Status { get; set; }
        public string Acknowledgement { get; set; }
        public Guid? ReferenceId { get; set; }
        public string Response { get; set; }
        public string SentRecordJson { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}