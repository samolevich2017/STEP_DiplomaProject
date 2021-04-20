using LibraryProject.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.IO;
using LibraryProject.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System;

namespace LibraryProject.Controllers {

    public class BookController : Controller {

        // коллекция-каталог книг
        List<Books> list_books = new List<Books>();

        // коллекция авторов
        List<Authors> list_authors = new List<Authors>();

        // коллекция экземпляров книг
        List<Copies> list_copies = new List<Copies>();

        // коллекция жанров книг
        List<Genres> list_genres = new List<Genres>();

        // коллекция id жанров и книг
        List<BooksGenres> list_bGenres = new List<BooksGenres>();

        // контекст данных
        ApplicationContext context = new ApplicationContext();

        // модель представления для работы с каталогом
        BooksViewModel dvm = new BooksViewModel();

        public BookController() {
            list_books = context.Books.ToList(); // инициализация коллекции книг из 
            list_authors = context.Authors.ToList(); // инициализация коллекции авторов книг из контекста
            list_copies = context.Copies.ToList(); // инициализация коллекции экземпляров книг из контекста
            list_genres = context.Genres.ToList(); // инициализация коллекции жанров книг из контекста
            list_bGenres = context.BooksGenres.ToList(); // инициализация коллекции id жанров и книг из контекста
        }

        // метод возвращающий представление с каталогом книг
        public IActionResult BookList(int? selectYearRange, bool? availStatus, string[] selected_genres, string[] selected_authors, string sortType, string searchInput, int page = 1, string filterReset = "false") {

            const int page_size = 12; // кол-во элементов отображающихся на одной странице

            // проверяем, если была нажата кнопка сброса, то вызываем метод сброса фильтра
            if (Convert.ToBoolean(filterReset) == true)
                ResetFilter();

            // устанавливаем год в фильтр из сессии, если не были переданы значения
            if(selectYearRange == null) {
                if (HttpContext.Session.GetInt32("selectYearRange").HasValue) {
                    selectYearRange = HttpContext.Session.GetInt32("selectYearRange");
                }
                else {
                    selectYearRange = 2005;
                }
            } // if

            // устанавливаем жанры выбранные в фильтре из сессии, если не были переданы значения
            if(selected_genres.Length == 0)
                selected_genres = SetFilterCheckBoxesFromSession(selected_genres, "genre_");

            // устанаваливаем авторов выбранных в фильтре из сессии, если не были переданы значения
            if(selected_authors.Length == 0)
                selected_authors = SetFilterCheckBoxesFromSession(selected_authors, "author_");
  

            // фильтрация данных
            // если было передано хоть одно значение фильтра, то вызываем метод фильтрации
            if (selectYearRange != null || availStatus != null || selected_genres.Length > 0 || selected_authors.Length > 0) {
                list_books = FilterBooks(selectYearRange, availStatus, list_books, selected_genres, selected_authors);
                
                // устанавливаем в сессии год из фильтра
                HttpContext.Session.SetInt32("selectYearRange", (int)selectYearRange);

                // устанавливаем в сессии жанры выбранные в фильтре
                for(int i = 0; i < selected_genres.Length; i++)
                    HttpContext.Session.SetString($"genre_{i+1}", selected_genres[i]);

                // устанавливаеем в сессии авторов выбранных в фильтре
                for (int i = 0; i < selected_authors.Length; i++)
                    HttpContext.Session.SetString($"author_{i + 1}", selected_authors[i]);
            }

            // устанавливаем тип сортировки из сессии, если в запросе он не указан
            if (string.IsNullOrEmpty(sortType)){
                sortType = HttpContext.Session.GetString("sortType");
            }

            // сортировка данных
            if (!string.IsNullOrEmpty(sortType)) {
                list_books = dvm.SortingBooks(sortType, list_books);
                HttpContext.Session.SetString("sortType", sortType);
            }

            // поиск
            if (!string.IsNullOrWhiteSpace(searchInput)) {
                list_books = SearchBooks(searchInput);
            }

            // реализация пагинации
            // -------------------------------------------------
            List<Books> source_o = list_books;
            int count_o = source_o.Count();
            List<Books> items_o = source_o.Skip((page - 1) * page_size).Take(page_size).ToList();

            PageViewModel pvm_o = new PageViewModel(count_o, page, page_size);
            dvm = new BooksViewModel {
                PageViewModel = pvm_o,
                Books = items_o
            };
            // -------------------------------------------------

            ViewBag.Page = page;
            ViewBag.GenresList = context.Genres.ToList();
            ViewBag.AuthorsList = context.Authors.ToList();
            return View(dvm);
        } // BookList


        // фильтрация
        private List<Books> FilterBooks(int? selectYearRange, bool? availStatus, List<Books> filtredColl, string[] selectedGenres, string[] selectedAuthors) {
            
            // фильтруем по жанрам
            if (selectedGenres.Length > 0) {

                List<BooksGenres> listBG = new List<BooksGenres>();

                // выборка коллекции обьектов с индексами книг, которые относятся к выбранным жанрам
                foreach (var item in selectedGenres) {
                    listBG.AddRange(context.BooksGenres.Select(o => o).Where(g => g.Genre.GenreName == item).ToList());
                }

                List<Books> listFiltredGenresBooks = new List<Books>();

                // выборка книг с указанным жанром
                foreach (var bg in listBG) {
                    listFiltredGenresBooks.Add(filtredColl.Select(o => o).Where(b => b.BooksGenres.Contains(bg)).ToList()[0]);
                }

                filtredColl = listFiltredGenresBooks;
            }

            // фильтруем по авторам
            if(selectedAuthors.Length > 0) {
                List<Authors> listA = new List<Authors>();

                // выборка коллекции обьектов авторов с заданными ФИО
                foreach(var author in selectedAuthors) {
                    listA.Add(context.Authors.Select(o => o).Where(a => a.SurnameNp == author).ToList()[0]);
                }

                List<Books> listFiltredAuthorsBooks = new List<Books>();

                foreach (var item in listA)
                    listFiltredAuthorsBooks.AddRange(filtredColl.Select(o => o).Where(b => b.AuthorId == item.Id).ToList());

                filtredColl = listFiltredAuthorsBooks;
            }

            // фильтруем по годам
            if (selectYearRange != null) {
                filtredColl = filtredColl.Select(o => o).Where(b => int.Parse(string.Join("", b.YearOfIssue.Where(c => char.IsDigit(c)))) >= selectYearRange).ToList();
                
                // передаем значение диапазона года выбранного при фильтрации
                ViewBag.SelectYearRange = selectYearRange;
            }

            // фильтруем по статусу
            if(availStatus == true) {
                filtredColl = filtredColl.Select(o => o).Where(b => b.Copies.AmountFreeCopies > 0).ToList();
            }

            return filtredColl;
        }

        // метод для сброса фильтра
        public void ResetFilter() {
            var listKeys = HttpContext.Session.Keys.ToList();
            if (listKeys.Count > 0)
                foreach (var item in listKeys)
                    if (item.ToString().Contains("author_") || item.ToString().Contains("genre_") || item.ToString().Contains("selectYearRange"))
                        HttpContext.Session.Remove(item);
        } // ResetFilter

        // метод для установки значений чек-боксов фильтра из сессии
        public string[] SetFilterCheckBoxesFromSession(string[] selected_checkboxes, string key) {
            var listKeys = HttpContext.Session.Keys.ToList();
            List<string> items = new List<string>();
            if (listKeys.Count > 0) {
                foreach (var item in listKeys)
                    if (item.ToString().Contains(key))
                        items.Add(HttpContext.Session.GetString(item));    
            } // if

            return items.ToArray();
        } // SetFilterCheckBoxesFromSession

        // метод поиска по каталогу
        public List<Books> SearchBooks(string search_input) {
            List<Books> searchBookList = new List<Books>();
            searchBookList = context.Books.Select(o => o).Where(b => b.Title.Contains(search_input) || b.Author.SurnameNp.Contains(search_input) || b.YearOfIssue.Contains(search_input)).ToList();
            return searchBookList;
        }

        // метод формирующий и возвращающий представление с детальной информацией о книге
        int IdCurrentBook;
        public IActionResult BookDetails(int id, int page) {
            
            // получим книгу, по которой кликнул пользователь
            Books book = list_books.Where(o => o.Id == id).ToList().First();
            IdCurrentBook = book.Id;

            // TODO: переписать логику формирования списка жанров текущей книги
            List<BooksGenres> listBookGenres = context.BooksGenres.Select(o => o).Where(b => b.BookId == book.Id).ToList();
            List<string> listGenresCurrentBook = new List<string>();
            foreach(var item in listBookGenres) {
                listGenresCurrentBook.Add(list_genres.Where(g => g.Id == item.GenreId).ToList()[0].GenreName.ToString());
            }

            ViewData["Title"] = $"Книга - \"{book.Title.ToString()}\"";
            ViewBag.PageNumber = page;
            ViewBag.Genres = listGenresCurrentBook;
            return View(book);
        } // BookDetails

        // попап для отображения гостям, которые попытались забронировать книгу не войдя в аккаунт
        public IActionResult UnAuthorizeTryBooking() {
            return PartialView();
        }

        // попап для подтверждения бронирования книги
        public IActionResult BookingBook(int id) {
            return PartialView(context.Books.Find(id));
        }

        // метод для бронирования книги пользователем
        public IActionResult BookingBookForReader(int bookId) {
            int? id = Convert.ToInt32(Request.Cookies["authorizeUserCode"]);
            Books currentBook = context.Books.Find(bookId);

            // если текущая книга выбрана и кол-во ее свободных экземпляров больше 0
            // добавляем запись о брони книги
            if (currentBook != null && currentBook.Copies.AmountFreeCopies > 0) {
                // уменьшаем кол-во 
                context.Copies.Select(o => o).Where(b => b.IdBook == bookId).FirstOrDefault().AmountFreeCopies--;
            }

            // добавляем книгу на соответствующую полку читателю
            if (currentBook != null && currentBook.Copies.AmountFreeCopies > 0) {
                // добавляем запись о брони книги
                context.Readers.Find(id).ReadersShelfs.Add(new ReadersShelfs() { IdCategoryShelf = 3, IdBook = bookId });
            }
            else if (currentBook != null && currentBook.Copies.AmountFreeCopies == 0) {
                context.ReadersShelfs.Add(new ReadersShelfs() { IdCategoryShelf = 2, IdBook = bookId, IdReader = (int)id });
            }

            // добавляем запись о брони книги
            context.BookingRecords.Add(new BookingRecords() { IdBook = bookId, BookingDate = DateTime.Now.Date, DateOfCompletion = DateTime.Now.AddDays(3).Date, IdReader = id });

            context.SaveChanges();

            return RedirectToAction("BookDetails");
        }

        [HttpPost]
        public IActionResult UnAuthorizeRedirect() {
            return RedirectToAction("Authorization", "Cabinet");
        }

    } // class BookController
    
} // namespace
