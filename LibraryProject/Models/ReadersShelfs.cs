using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class ReadersShelfs
    {
        public int Id { get; set; }
        public int IdReader { get; set; }
        public int IdBook { get; set; }
        public int IdCategoryShelf { get; set; }

        public virtual Books IdBookNavigation { get; set; }
        public virtual CategoriesShelfs IdCategoryShelfNavigation { get; set; }
        public virtual Readers IdReaderNavigation { get; set; }
    }
}
