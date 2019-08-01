using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class MonthlySurveyBooks
    {
        public MonthlySurveyBooks()
        {
            MonthlySurveyBooksMapping = new HashSet<MonthlySurveyBooksMapping>();
        }

        public long SurveyId { get; set; }
        public int MarketId { get; set; }
        public string SurveyBookName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public virtual ICollection<MonthlySurveyBooksMapping> MonthlySurveyBooksMapping { get; set; }
    }
}