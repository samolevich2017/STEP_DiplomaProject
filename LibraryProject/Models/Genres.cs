using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class Genres
    {
        public Genres()
        {
            BooksGenres = new HashSet<BooksGenres>();
        }

        public int Id { get; set; }
        public string GenreName { get; set; }

        public virtual ICollection<BooksGenres> BooksGenres { get; set; }
    }
}
