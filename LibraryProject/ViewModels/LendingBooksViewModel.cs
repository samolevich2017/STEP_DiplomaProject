using System;
using System.Collections.Generic;
using System.Linq;
using LibraryProject.Models;
using System.Threading.Tasks;

namespace LibraryProject.ViewModels {
    public class LendingBooksViewModel {
        
        // коллекция книг
        public IEnumerable<Books> Books { get; set; }

        // коллекция авторов книг
        public IEnumerable<Authors> Authors { get; set; }

        // коллекция экземпляров книг
        public IEnumerable<Copies> Copies { get; set; }

        // коллекция жанров книг 
        public IEnumerable<Genres> Genres { get; set; }

        // коллекция id жанра и книг
        public IEnumerable<BooksGenres> BooksGenres { get; set; }

        public IEnumerable<LendingBooks> LendingBooks { get; set; }

        // модель представления для пагинации
        public PageViewModel PageViewModel { get; set; }

        ApplicationContext context = new ApplicationContext();

        public LendingBooksViewModel() {

        }


    }
}
