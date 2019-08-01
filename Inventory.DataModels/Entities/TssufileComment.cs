using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class TssufileComment
    {
        public int Id { get; set; }
        public int? HdrId { get; set; }
        public int? MstId { get; set; }
        public string TssufileCommentDescription { get; set; }
        public int? CommentId { get; set; }
        public string Comment { get; set; }
        public string TssufileCommentService { get; set; }
        public string TssufileCommentType { get; set; }
        public string Book { get; set; }
        public string Demo { get; set; }
        public string Category { get; set; }
        public string Stream { get; set; }
        public DateTime? LastChangedDate { get; set; }
        public DateTime? ProcessDateTime { get; set; }
    }
}