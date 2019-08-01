using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class UserDetail
    {
        public UserDetail()
        {
            UserChannel = new HashSet<UserChannel>();
            UserMarket = new HashSet<UserMarket>();
        }

        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string MiddelName { get; set; }
        public string LastName { get; set; }
        public int? RoleId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public virtual ICollection<UserChannel> UserChannel { get; set; }
        public virtual ICollection<UserMarket> UserMarket { get; set; }
    }
}