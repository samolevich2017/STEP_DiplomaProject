using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class LendingBooks
    {
        public int Id { get; set; }
        public int IdLibrarian { get; set; }
        public int IdCopy { get; set; }
        public int IdReader { get; set; }
        public DateTime DateOfIssue { get; set; }
        public DateTime ExpectedDateOfReturn { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public bool StatusNode { get; set; }

        public virtual Copies IdCopyNavigation { get; set; }
        public virtual Librarians IdLibrarianNavigation { get; set; }
        public virtual Readers IdReaderNavigation { get; set; }
    }
}
