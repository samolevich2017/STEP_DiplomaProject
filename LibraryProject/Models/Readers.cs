using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryProject.Models
{
    public partial class Readers
    {
        public Readers()
        {
            BookingRecords = new HashSet<BookingRecords>();
            LendingBooks = new HashSet<LendingBooks>();
            ReadersShelfs = new HashSet<ReadersShelfs>();
        }

        public int Id { get; set; }
        public string SurnameReader { get; set; }
        public string NameReader { get; set; }
        public string PatronymicReader { get; set; }
        public string LoginReader { get; set; }
        public string EmailReader { get; set; }
        public string PasswordReader { get; set; }
        public string AdressReader { get; set; }
        public string PhoneNumberReader { get; set; }
        public string PhotoReaderUrl { get; set; }

        public virtual ICollection<BookingRecords> BookingRecords { get; set; }
        public virtual ICollection<LendingBooks> LendingBooks { get; set; }
        public virtual ICollection<ReadersShelfs> ReadersShelfs { get; set; }
    }
}
