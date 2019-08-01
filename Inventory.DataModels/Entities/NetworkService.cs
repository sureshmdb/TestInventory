using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class NetworkService
    {
        public NetworkService()
        {
            NetworkServiceMapping = new HashSet<NetworkServiceMapping>();
        }

        public long NetworkServiceId { get; set; }
        public string NetworkName { get; set; }
        public bool IsDeleted { get; set; }

        public virtual ICollection<NetworkServiceMapping> NetworkServiceMapping { get; set; }
    }
}