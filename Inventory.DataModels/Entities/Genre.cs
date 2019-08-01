using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class Genre
    {
        public Genre()
        {
            GenreInventoryRange = new HashSet<GenreInventoryRange>();
            GenreMapping = new HashSet<GenreMapping>();
            GenreNetworkMapping = new HashSet<GenreNetworkMapping>();
            ProgramGenreLocal = new HashSet<ProgramGenreLocal>();
            ProgramGenreNetwork = new HashSet<ProgramGenreNetwork>();
        }

        public long GenreId { get; set; }
        public string GenreName { get; set; }
        public string GenreDescription { get; set; }
        public int? IsDelete { get; set; }
        public int? Sortorder { get; set; }
        public int? ParentRange { get; set; }
        public long? CloneSourceId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public long? CreatedBy { get; set; }
        public long? UpdatedBy { get; set; }
        public bool IsNetwork { get; set; }
        public long? NetworkGenreId { get; set; }

        public virtual GenreSaleRange GenreSaleRange { get; set; }
        public virtual ICollection<GenreInventoryRange> GenreInventoryRange { get; set; }
        public virtual ICollection<GenreMapping> GenreMapping { get; set; }
        public virtual ICollection<GenreNetworkMapping> GenreNetworkMapping { get; set; }
        public virtual ICollection<ProgramGenreLocal> ProgramGenreLocal { get; set; }
        public virtual ICollection<ProgramGenreNetwork> ProgramGenreNetwork { get; set; }
    }
}