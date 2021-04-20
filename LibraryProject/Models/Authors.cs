using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class Authors
    {
        public Authors()
        {
            Books = new HashSet<Books>();
        }

        public int Id { get; set; }
        public string SurnameNp { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
