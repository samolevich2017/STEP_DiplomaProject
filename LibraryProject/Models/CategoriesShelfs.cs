using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class CategoriesShelfs
    {
        public CategoriesShelfs()
        {
            ReadersShelfs = new HashSet<ReadersShelfs>();
        }

        public int Id { get; set; }
        public string Category { get; set; }

        public virtual ICollection<ReadersShelfs> ReadersShelfs { get; set; }
    }
}
