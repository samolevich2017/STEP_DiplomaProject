using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class BooksGenres
    {
        public int BookId { get; set; }
        public int GenreId { get; set; }

        public virtual Books Book { get; set; }
        public virtual Genres Genre { get; set; }
    }
}
