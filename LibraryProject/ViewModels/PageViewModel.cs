using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.ViewModels {

    // ViewModel для реализации пагинации
    public class PageViewModel {
        public int PageNumber { get; private set; } // номер сраницы
        public int TotalPages { get; private set; } // общее кол-во страниц

        public PageViewModel(int count, int pageNumber, int pageSize) {
            PageNumber = pageNumber;
            TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        }

        // определяет, есть ли предыдущая страницы
        public bool HasPreviousPage {
            get {
                return (PageNumber > 1);
            }
        } // HasPreviousPage


        // оповещает, есть ли следующая страница
        public bool HasNextPage {
            get {
                return (PageNumber < TotalPages);
            }
        } // HasNextPage 
    }
}
