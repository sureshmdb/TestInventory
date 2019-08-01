using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Market
    {
        public Market()
        {
            UserMarket = new HashSet<UserMarket>();
        }

        public long MdmmarketId { get; set; }
        public int MarketLegacyCode { get; set; }
        public int MarketSourceId { get; set; }
        public string MarketLegacyName { get; set; }
        public string MarketType { get; set; }
        public short? Rank { get; set; }
        public byte? TimeZone { get; set; }
        public string ClassCode { get; set; }
        public bool? DaylightSaving { get; set; }
        public int? Dmacode { get; set; }
        public string GeorgaphyIndicator { get; set; }
        public string GeographyName { get; set; }
        public int? RatingSourceId { get; set; }
        public string MarketAbbrev { get; set; }
        public bool? Isdummy { get; set; }
        public string StateProvince { get; set; }
        public string MeasurementType { get; set; }
        public int? CollectionMethodId { get; set; }
        public string PlayBackTypeId { get; set; }
        public byte? SubSampleIndicator { get; set; }
        public string MarketName { get; set; }
        public byte? SurveySampleTypeId { get; set; }
        public TimeSpan? OvnDayStart { get; set; }
        public byte? LocalNational { get; set; }
        public byte? AdminUnderwriteId { get; set; }
        public int? TradingAreaId { get; set; }

        public virtual ICollection<UserMarket> UserMarket { get; set; }
    }
}