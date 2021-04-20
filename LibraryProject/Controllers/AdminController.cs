using LibraryProject.Models;
using LibraryProject.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LibraryProject.Controllers {

    [ResponseCache(Location = ResponseCacheLocation.Any, Duration = 900)]
    public class AdminController : Controller {

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

        IWebHostEnvironment _appEnvironment ;

        string uploadedCoverUrl = "";


        public AdminController(IWebHostEnvironment appEnvironment) {
            context.Readers.ToList().Last().NameReader = "Алена";
            context.Readers.ToList().Last().SurnameReader = "Глушкова";
            context.Readers.ToList().Last().PatronymicReader = "Андреевна";
            context.SaveChanges();


            list_books.AddRange(context.Books.ToList()); // инициализация коллекции книг из 
            list_authors.AddRange(context.Authors.ToList()); // инициализация коллекции авторов книг из контекста
            list_copies.AddRange(context.Copies.ToList()); // инициализация коллекции экземпляров книг из контекста
            list_genres.AddRange(context.Genres.ToList()); // инициализация коллекции жанров книг из контекста
            list_bGenres.AddRange(context.BooksGenres.ToList()); // инициализация коллекции id жанров и книг из контекста
            _appEnvironment = appEnvironment;
        }

        // форма авторизации
        public IActionResult AdminAuthorization() {
            return View();
        }

        public IActionResult AdminStatistic() {
            return PartialView();
        }

        public IActionResult AdminReports() {
            return PartialView();
        }

        #region Управление каталогом 

        // управление каталогом
        public IActionResult AdminCatalog(string sortTableBook, string surnameNP, int page = 1) {
            
            const int page_size = 7; // кол-во элементов на странице

            // устанавливаем тип сортировки из сессии, если в запросе он не указан
            if (string.IsNullOrEmpty(sortTableBook)) {
                sortTableBook = HttpContext.Session.GetString("sortTable");
            }

            // сортировка данных
            if (!string.IsNullOrEmpty(sortTableBook)) {
                list_books = dvm.SortingBooks(sortTableBook, list_books);
                HttpContext.Session.SetString("sortTable", sortTableBook);
            }

            // реализация пагинации
            List<Books> source_o = list_books;
            int count_o = source_o.Count();
            List<Books> items_o = source_o.Skip((page - 1) * page_size).Take(page_size).ToList();

            PageViewModel pvm_o = new PageViewModel(count_o, page, page_size);
            dvm = new BooksViewModel {
                PageViewModel = pvm_o,
                Books = items_o
            };

            ViewBag.CatalogLenght = context.Books.ToList().Count;
            ViewData["Title"] = "Каталог";
            return View(dvm);
        }

        // метод вызывающий модальное окно с деталями обьекта 
        // для редактирования или удаления
        public ActionResult AdminDetailsBook(int id = 1) {
            Books selectedBook = context.Books.Find(id);

            if (selectedBook != null) {
                List<BooksGenres> listBookGenres = context.BooksGenres.Select(o => o).Where(b => b.BookId == selectedBook.Id).ToList();
                List<string> listGenresCurrentBook = new List<string>();
                foreach (var item in listBookGenres) {
                    listGenresCurrentBook.Add(list_genres.Where(g => g.Id == item.GenreId).ToList()[0].GenreName.ToString());
                }

                ViewBag.Genres = listGenresCurrentBook;
                BooksEditViewModel booksEditViewModel = new BooksEditViewModel(selectedBook);
                return PartialView(booksEditViewModel);
            }

            return NotFound($"Элемент с ID={id} не найден!");
        }

        // метод асинхронной загрузки файла изображения из формы на сервер (для загрузки обложек)
        public void OnPostUploadAsync(IFormFile uploadFile) {
            var filePath = @"\covers_img\" + uploadFile.FileName;

            // сохраняем файл в папку Files в каталоге wwwroot
            using (var fileStream = new FileStream(_appEnvironment.WebRootPath + filePath, FileMode.Create)) {
                 uploadFile.CopyTo(fileStream);
            }

            uploadedCoverUrl = filePath;
        }

        // метод ковертации файла изображения в Base64
        public string GetBase64StringForImage(string imgPath) {
            byte[] imageBytes = System.IO.File.ReadAllBytes(_appEnvironment.WebRootPath + imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }

        // ---------------- Редактирование книги -----------------------
        [HttpPost]
        public IActionResult AdminDetailsBookEdit(int id, string inputBookTitle, string inputBookAuthor, int selectBookYear, string inputBookDescription, string selected_genres, string file) {
            
            // получим редактируемую книгу
            Books newBook = context.Books.Find(id);

            // устанавливаем название книги
            newBook.Title = inputBookTitle;
            // data:image/jpeg;base64,


            // если в данных отправленых формой есть файл, то записать его в директорию
            if (HttpContext.Request.Form.Files.Count > 0)
                OnPostUploadAsync(HttpContext.Request.Form.Files[0]);

            // записываем обложку книги в виде байтов
            string cover = file.Remove(0, 23);
            if (!string.IsNullOrWhiteSpace(cover)) 
                newBook.CoverImgUrl = cover;
            

            // узнаем автора добавляемой книги и проверим, есть ли он в базе
            // если есть, то достаем его id и присваиваем книге
            // иначе же добавляем нового автора в базу и берем его id
            if (context.Authors.Select(o => o).Where(a => a.SurnameNp == inputBookAuthor).ToList().Count > 0) {
                newBook.AuthorId = context.Authors.Select(o => o).Where(a => a.SurnameNp == inputBookAuthor).First().Id;
            }
            else {
                context.Authors.Add(new Authors() { SurnameNp = inputBookAuthor });
                context.SaveChanges();
                newBook.AuthorId = context.Authors.ToList().Last().Id;
            } // if/else

            // устанавливаем год выпуска книги
            newBook.YearOfIssue = $"{selectBookYear} год";

            // устанавливаем описание книги
            newBook.DescriptionBook = inputBookDescription;

            // проходим по коллекции отмеченых жанров и проверяем, если у книги уже имеется такой жанр - пропускаем итерацию
            // иначе - добавляем новую запись о жанре данной книги
            if(!string.IsNullOrWhiteSpace(selected_genres)) {
                // очищаем существующие жанры книги
                List<int> genresChecked = selected_genres.Split(',').Select(int.Parse).ToList();
                foreach(var item in newBook.BooksGenres.ToList()) {
                    for (int i = 0; i < genresChecked.Count; i++) {
                        if(item.GenreId != genresChecked[i]) {
                            context.BooksGenres.Remove(item);
                            context.SaveChanges();
                        }
                    }
                }
                for (int i = 0; i < genresChecked.Count; i++) {
                    if (newBook.BooksGenres.Select(o => o).Where(b => b.GenreId == genresChecked[i]).ToList().Count > 0)
                        continue;
                    else
                        newBook.BooksGenres.Add(new BooksGenres() { BookId = newBook.Id, GenreId = genresChecked[i] });
                } // for
            } // if

            context.Entry(newBook).State = EntityState.Modified;
            context.SaveChanges();

            return Redirect("AdminDetailsBook");
        }

        // ----------------------------- Добавление книги -----------------------
        public IActionResult AdminApendBook() {
            return PartialView(context);
        }

        [HttpPost]
        public IActionResult AdminApendBook(string inputApendBookTitle, string inputApendBookAuthor, int selectApendBookYear, string inputApendBookDescription, string selectedApend_genres, int inputAmountCopies, string file) {
           
            Books apendBook = new Books();

            // если основные поля не пустые, то начинаем добавление
            if(!string.IsNullOrWhiteSpace(inputApendBookTitle) && !string.IsNullOrWhiteSpace(inputApendBookAuthor) && !string.IsNullOrWhiteSpace(selectedApend_genres)) {
            
                // установим название книги
                apendBook.Title = inputApendBookTitle;

                // узнаем автора добавляемой книги и проверим, есть ли он в базе
                // если есть, то достаем его id и присваиваем книге
                // иначе же добавляем нового автора в базу и берем его id
                if (context.Authors.Select(o => o).Where(a => a.SurnameNp == inputApendBookAuthor).ToList().Count > 0) {
                    apendBook.AuthorId = context.Authors.Select(o => o).Where(a => a.SurnameNp == inputApendBookAuthor).First().Id;
                }
                else {
                    context.Authors.Add(new Authors() { SurnameNp = inputApendBookAuthor });
                    context.SaveChanges();
                    apendBook.AuthorId = context.Authors.ToList().Last().Id;
                }

                // установим год выпуска
                apendBook.YearOfIssue = $"{selectApendBookYear} год";

                // установим описание если оно есть
                if (!string.IsNullOrWhiteSpace(inputApendBookDescription))
                    apendBook.DescriptionBook = inputApendBookDescription;

                // если в данных отправленых формой есть файл, то записать его в директорию
                //if (HttpContext.Request.Form.Files.Count > 0)
                //    OnPostUploadAsync(HttpContext.Request.Form.Files[0]);

                //// записываем обложку книги в виде байтов
                //if (!string.IsNullOrWhiteSpace(uploadedCoverUrl))
                //    apendBook.CoverImgUrl = GetBase64StringForImage(uploadedCoverUrl);

                // записываем обложку книги в виде байтов
                string cover = file.Remove(0, 23);
                if (!string.IsNullOrWhiteSpace(cover))
                    apendBook.CoverImgUrl = cover;

                // если обьект книги не пустой, то добавляем его в контекст
                if (apendBook != null) {
                    context.Books.Add(apendBook);
                    context.SaveChanges();

                    // устанавливаем запись об экземплярах книги
                    context.Copies.Add(new Copies() { IdBook = context.Books.ToList().Last().Id, Amount = inputAmountCopies, AmountFreeCopies = inputAmountCopies });
                }

                // проходим по коллекции отмеченых жанров и проверяем, если у книги уже имеется такой жанр - пропускаем итерацию
                // иначе - добавляем новую запись о жанре данной книги
                List<int> genresChecked = selectedApend_genres.Split(',').Select(int.Parse).ToList();
                if (!string.IsNullOrWhiteSpace(selectedApend_genres)) {
                    for (int i = 0; i < genresChecked.Count; i++) {
                            context.BooksGenres.Add(new BooksGenres() { BookId = context.Books.ToList().Last().Id, GenreId = genresChecked[i] });
                    } // for
                } // if

                // сохраняем изменения в контексте
                context.SaveChanges();
            }

            return RedirectToAction("AdminCatalog");
        }

        // -------------------------------------------------- Удаление книги ------------------------------
        // !!! Не используется, но пусть будет...
        [HttpPost]
        public IActionResult AdminRemoveBook(int id) {

            Books deletedBook = context.Books.Find(id);

            // проверим, есть ли вообще такая книга в бд
            if(deletedBook != null) {

                // удаляем все возможные записи о книге в других местах
                context.BooksGenres.RemoveRange(context.BooksGenres.Select(o => o).Where(bg => bg.BookId == deletedBook.Id).ToList());
                context.Copies.RemoveRange(context.Copies.Select(o => o).Where(c => c.IdBook == deletedBook.Id));
                // удаляем книгу
                context.Books.Remove(deletedBook);

                // сохраняем изменения контекста
                context.SaveChanges();
            }

            return RedirectToAction("AdminCatalog");
        }

        // ----------------------------------------------- Импорт книг из JSON ------------------------------------
        public IActionResult AdminImportBooks() {
            return PartialView();
        }

        [HttpPost]
        public IActionResult AdminImportBooks(string json) {

            // имя файла
            string fileImportName = HttpContext.Request.Form.Files[0].FileName;

            // путь к файлу на сервере
            string filePath = _appEnvironment.WebRootPath + fileImportName;

            // загружаем файл на сервер (для работы с файлом)
            OnPostUploadAsync(HttpContext.Request.Form.Files[0]);

            // если файл на сервере существует начинаем импорт
            if (System.IO.File.Exists(filePath)) {

                // десериализуем коллекцию книг из полученного файла
                List<ImportingBook> books = new List<ImportingBook>();

                using (StreamReader file = System.IO.File.OpenText(filePath)) {
                    JsonSerializer serializer = new JsonSerializer();
                    books = (List<ImportingBook>)serializer.Deserialize(file, typeof(List<ImportingBook>));
                } // using

                // если коллекция книг из файла не пустая, то делаем импорт в контекст
                if(books.Count > 0) {
                    BooksViewModel bvm = new BooksViewModel() { ImportingBooks = books };
                    bvm.ImportBooksFromJSON(ref context);
                }

                // удаляем файл с сервера
                FileInfo fi = new FileInfo(filePath);
                fi.Delete();

            } // if


            return RedirectToAction("AdminCatalog");
        } // AdminImportBooks

        #endregion

        #region Управление библиотекарями
        
        // представление с таблицей библиотекарей
        public IActionResult AdminLibrarians() {
            ViewData["Title"] = "Библиотекари";
            return View(context);
        }



        #endregion


        #region Управление выдачами книг

        // управление выдачами книг
        public IActionResult AdminLendingBooks() {

            ViewData["Title"] = "Выдачи книг";
            return View(context);
        }

        [HttpPost]
        public IActionResult AdminLendingBooks(int id) {

            LendingBooks lb = context.LendingBooks.Find(id);
            
            if(lb != null) {

                lb.ActualReturnDate = DateTime.Now.Date;
                lb.StatusNode = true;

                // id - книги
                int idBook = context.Copies.Select(o => o).Where(c => c.IdCopy == lb.IdCopy).ToList()[0].IdBook.Value;
                
                // изменим кол-во доступных экз
                context.Copies.Select(o => o).Where(c => c.IdBook == idBook).ToList()[0].AmountFreeCopies++;

                // переставим книгу на полку - прочитано
                context.ReadersShelfs.Select(o => o).Where(r => r.IdReader == lb.IdReader && r.IdBook == idBook).ToList()[0].IdCategoryShelf = 1;

                context.Entry(lb).State = EntityState.Modified;
                context.SaveChanges();
            }
            
            return View();
        }

        #endregion

        #region Управление бронью книг
        
        public IActionResult AdminBookingBooks() {

            ViewData["Title"] = "Бронь книг";
            return View(context);
        }

        [HttpPost]
        public IActionResult AdminBookingBooks(int id) {

            // получим запись о брони
            BookingRecords booking = context.BookingRecords.Find(id);

            // если у книги есть доступные экземпляры
            if(context.Books.Select(o=>o).Where(b=> b.Id == booking.IdBook).ToList()[0].Copies.AmountFreeCopies > 0) {

                // если бронь не пуста
                if(booking != null) {

                    // сформируем обьект записи о выдаче книги
                    LendingBooks lendingBooks = new LendingBooks() {
                        IdLibrarian = 1, // TODO: поменять хардкод на данные авторизованного библиотекаря
                        IdReader = (int)booking.IdReader,
                        IdCopy = context.Copies.Select(o=>o).Where(b => b.IdBook == booking.IdBook).FirstOrDefault().IdCopy,
                        DateOfIssue = DateTime.Today,
                        ExpectedDateOfReturn = DateTime.Today.AddDays(3),
                        StatusNode = false
                    };

                    // если запись о выдаче не пуста
                    if(lendingBooks != null) {

                        // добавляем запись о выдаче в контекст
                        context.LendingBooks.Add(lendingBooks);

                        // удаляем запись о брони из контекста
                        context.BookingRecords.Remove(booking);

                        // уменьшаем кол-во доступных экземпляров книги
                        context.Copies.Select(o => o).Where(c => c.IdBook == booking.IdBook).FirstOrDefault().AmountFreeCopies--;

                        // убираем с полки бронированых и ожидающих
                        context.ReadersShelfs.RemoveRange(context.ReadersShelfs.Select(o => o).Where(b => b.IdBook == (int)booking.IdBook).ToList());

                        // добавляем на полку читателю 
                        context.ReadersShelfs.Add(new ReadersShelfs() { IdBook = (int)booking.IdBook, IdReader = (int)booking.IdReader, IdCategoryShelf = 4 });

                        // убираем с полки ожидающих
                        // context.ReadersShelfs.Remove(context.ReadersShelfs.Select(o => o).Where(b => b.IdBook == (int)booking.IdBook && b.IdCategoryShelf == 3).ToList()[0]);

                        // сохраняем изменения в контексте
                        context.SaveChanges();
                    }
                } // if
            }
           
            return RedirectToAction("AdminBookingBooks");
        }

        #endregion

        #region Управление читателями

        public IActionResult AdminReaders() {

            ViewData["Title"] = "Читатели";
            return View(context);
        }

        #endregion

    }
}
