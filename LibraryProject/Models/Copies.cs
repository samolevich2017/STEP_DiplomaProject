using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class Copies
    {
        public Copies()
        {
            LendingBooks = new HashSet<LendingBooks>();
        }

        public int IdCopy { get; set; }
        public int? IdBook { get; set; }
        public int Amount { get; set; }
        public int AmountFreeCopies { get; set; }

        public virtual Books IdBookNavigation { get; set; }
        public virtual ICollection<LendingBooks> LendingBooks { get; set; }
    }
}
