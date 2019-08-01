using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Channel
    {
        public Channel()
        {
            UserChannel = new HashSet<UserChannel>();
        }

        public long MdmchannelId { get; set; }
        public decimal ChannelSourceId { get; set; }
        public string MdmchannelCallLetters { get; set; }
        public string MdmchannelLongName { get; set; }
        public int? MarketSourceId { get; set; }
        public int? PrimaryNetworkId { get; set; }
        public string DisplayName { get; set; }
        public int? ChannelLegacyCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? ExpiredDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? DistributorGroup { get; set; }
        public string ChannelTotalsIndicator { get; set; }
        public int? ChannelTypeCode { get; set; }
        public string BroadcastChannel { get; set; }
        public string TimeZone { get; set; }
        public DateTime? CallLetterChangeDate { get; set; }
        public byte? DistributionsourceType { get; set; }
        public int RatingSourceId { get; set; }
        public int? MarketOfOriginCode { get; set; }
        public string MdmChannelLegacyCallLetters { get; set; }
        public string ParentPlusIndicator { get; set; }
        public string ParentIndicator { get; set; }
        public string SatelliteIndicator { get; set; }
        public string AudienceEstimatesIndicator { get; set; }
        public string ReportabilityStatus { get; set; }
        public string ProgramNamesIndicator { get; set; }
        public byte? AdminUnderwriteId { get; set; }

        public virtual ICollection<UserChannel> UserChannel { get; set; }
    }
}