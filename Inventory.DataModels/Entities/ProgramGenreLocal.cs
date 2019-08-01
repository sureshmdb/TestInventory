using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramGenreLocal
    {
        public long Id { get; set; }
        public long ProgramId { get; set; }
        public long GenreId { get; set; }
        public bool IsDelete { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ProgramLocal Program { get; set; }
    }
}