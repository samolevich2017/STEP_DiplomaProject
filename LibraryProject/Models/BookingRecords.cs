using System;
using System.Collections.Generic;

namespace LibraryProject.Models
{
    public partial class BookingRecords
    {
        public int Id { get; set; }
        public int? IdReader { get; set; }
        public int? IdBook { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime DateOfCompletion { get; set; }

        public virtual Books IdBookNavigation { get; set; }
        public virtual Readers IdReaderNavigation { get; set; }
    }
}
