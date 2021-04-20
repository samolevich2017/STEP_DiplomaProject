using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class Books
    {
        public Books()
        {
            BookingRecords = new HashSet<BookingRecords>();
            BooksGenres = new HashSet<BooksGenres>();
            ReadersShelfs = new HashSet<ReadersShelfs>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public int? AuthorId { get; set; }
        public string DescriptionBook { get; set; }
        public string CoverImgUrl { get; set; }
        public string YearOfIssue { get; set; }

        public virtual Authors Author { get; set; }
        public virtual Copies Copies { get; set; }
        public virtual ICollection<BookingRecords> BookingRecords { get; set; }
        public virtual ICollection<BooksGenres> BooksGenres { get; set; }
        public virtual ICollection<ReadersShelfs> ReadersShelfs { get; set; }
    }
}
