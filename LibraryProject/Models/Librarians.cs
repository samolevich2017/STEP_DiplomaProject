using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class Librarians
    {
        public Librarians()
        {
            LendingBooks = new HashSet<LendingBooks>();
        }

        public int Id { get; set; }
        public string SurnameLibrarian { get; set; }
        public string NameLibrarian { get; set; }
        public string PatronymicLibrarian { get; set; }
        public string CodeLibrarian { get; set; }

        public virtual ICollection<LendingBooks> LendingBooks { get; set; }
    }
}
