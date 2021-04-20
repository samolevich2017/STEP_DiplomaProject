using LibraryProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.ViewModels {
    
    // ViewModel для работы с редактированием книг
    public class BooksEditViewModel {

        // выбранная модель книги
        public Books SelectedBook { get; set; }

        // получим контекст приложения
        public ApplicationContext context;

        public BooksEditViewModel(Books book) {
            context = new ApplicationContext();
            SelectedBook = book;
        }

    } // CatalogViewModel
}
