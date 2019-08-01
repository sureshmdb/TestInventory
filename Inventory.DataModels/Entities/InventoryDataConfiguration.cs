using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class InventoryDataConfiguration
    {
        public Guid Id { get; set; }
        public string DataConsumerName { get; set; }
        public string TokenEndpoint { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string GrantType { get; set; }
        public string Scope { get; set; }
        public string ServiceEndpoint { get; set; }
    }
}