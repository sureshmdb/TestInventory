using System;
using System.Collections.Generic;

namespace Inventory.DataModels.Entities
{
    public partial class ProgramGenreNetwork
    {
        public long Id { get; set; }
        public long ProgramId { get; set; }
        public long GenreId { get; set; }
        public bool IsDelete { get; set; }

        public virtual Genre Genre { get; set; }
        public virtual ProgramNetwork Program { get; set; }
    }
}