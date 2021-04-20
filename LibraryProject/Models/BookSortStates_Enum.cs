using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Models {
    public enum BookSortStates_Enum {
        FirstMostPopular, // сначала популярные
        TitleDesc, // названия по убыванию (по алфавиту)
        YearDesc, // год выпуска по убыванию
        TitleAsc, // названия по возрастанию (с конца алфавита)
        YearAsc // год выпуска по возрастанию
    }
}
