using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class MonthlySurveyBooksMapping
    {
        public long Id { get; set; }
        public long SurveyId { get; set; }
        public long MdmmarketId { get; set; }
        public string CollectionMethod { get; set; }
        public string PlaybackType { get; set; }
        public string SurveySampleType { get; set; }
        public string SubSampleIndicator { get; set; }

        public virtual MonthlySurveyBooks Survey { get; set; }
    }
}