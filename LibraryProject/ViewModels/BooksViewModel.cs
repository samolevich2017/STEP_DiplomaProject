using LibraryProject.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace LibraryProject.ViewModels {
    public class BooksViewModel {

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

        // модель представления для пагинации
        public PageViewModel PageViewModel { get; set; }

        ApplicationContext context = new ApplicationContext();

        // коллекция импортируемых книг
        public List<ImportingBook> ImportingBooks { get; set; }


        // функция импорта обьектов книг из файла JSON
        public void ImportBooksFromJSON(ref ApplicationContext context) {

            // если коллекция книг для импорта не пустая, то начинаем импорт
            if(ImportingBooks != null) {
                
                // объект добавляемой книги, который будет формироваться далее
                Books book;

                // проходим по полученной коллекции книг из файла
                foreach (var item in ImportingBooks) {

                    // если такая книга есть в базе, то пропускаем итерацию
                    if (context.Books.Select(b => b).Where(n => n.Title == item.Title).ToList().Count > 0)
                        continue;

                    // создаем объект книги
                    book = new Books();

                    // узнаем автора добавляемой книги и проверим, есть ли он в базе
                    // если есть, то достаем его id и присваиваем книге
                    // иначе же добавляем нового автора в базу и берем его id
                    if (context.Authors.Select(o => o).Where(a => a.SurnameNp == item.Author).ToList().Count > 0) {
                        book.AuthorId = context.Authors.Select(o => o).Where(a => a.SurnameNp == item.Author).First().Id;
                    }
                    else {
                        context.Authors.Add(new Authors() { SurnameNp = item.Author });
                        context.SaveChanges();
                        book.AuthorId = context.Authors.ToList().Last().Id;
                    }

                    book.Title = item.Title; // название книги
                    book.CoverImgUrl = item.CoverUrl; // обложка книги
                    book.Author = context.Authors.Find(book.AuthorId); // автор книги
                    book.DescriptionBook = item.Description; // описание книги
                    book.YearOfIssue = item.PublishYear; // год выпуска книги

                    // если такого жанра, как у добавляемой книги, нет в списке жанров, 
                    // то добавляем новый жанр в список жанров
                    if (context.Genres.Select(o => o).Where(g => g.GenreName == item.Gener).ToList().Count == 0) {
                        context.Genres.Add(new Genres() { GenreName = item.Gener });
                        context.SaveChanges();
                    }

                    // добавляем книгу в контекст
                    context.Books.Add(book);
                    context.SaveChanges();
                    context.Copies.Add(new Copies() { IdBook = context.Books.ToList().Last().Id, Amount = 3, AmountFreeCopies = 3 });

                    // присваиваем добавленной книге жанры
                    foreach (var gen in context.Genres.ToList())
                        if (gen.GenreName == item.Gener)
                            context.BooksGenres.Add(new BooksGenres() { BookId = context.Books.ToList().Last().Id, GenreId = gen.Id });

                    // сохраняем изменения контекста
                    context.SaveChanges();
                }
            }

        } // ImportBooksFromJSON

        // метод для сортировки коллекции книг - возвращает отсортированную коллекцию
        public List<Books> SortingBooks(string sortType, List<Books> sortingCollection) {
            switch (sortType) {

                // сначала популярные
                case "sort_popularFirst":
                    // TODO: сравнивание кол-ва заказов книг
                    break;

                // названия по убыванию
                case "sort_from_A_to_Z":
                    sortingCollection = sortingCollection.OrderBy(b => b.Title).ToList();
                    break;

                // год выпуска по возрастанию
                case "sort_from_Old_to_New":
                    sortingCollection = sortingCollection.OrderBy(b => b.YearOfIssue).ToList();
                    break;

                // названия по возрастанию
                case "sort_from_Z_to_A":
                    sortingCollection = sortingCollection.OrderByDescending(b => b.Title).ToList();
                    break;

                // год выпуска по убыванию
                case "sort_from_New_to_Old":
                    sortingCollection = sortingCollection.OrderByDescending(b => b.YearOfIssue).ToList();
                    break;

                // по автору по алфавиту
                case "sort_authors_A_to_Z":
                    sortingCollection = sortingCollection.OrderBy(b => b.Author.SurnameNp).ToList();
                    break;

                // по умолчанию (ниче не делаем)
                case "sort_default":
                default:
                    break;
            }

            return sortingCollection;
        } // SortingBooks

        // метод создающий значение для атрибута src при выводе изображения в предствлении
        public static string CreateScrAttrForImg(string value) {
            
            // подразумеваем, что по умолчанию в значении передается ссылка
            string srcVal = value;

            // если значение не ссылка, то формируем строку с байтовым типом вывода
            if (!BooksViewModel.IsUrl(srcVal))
                srcVal = $"data:image/png;base64,{value}";

            return srcVal;
        } // CreateScrAttrForImg

        // метод проверяющий строку на предмет ссылки
        public static bool IsUrl(string url) {
            
            bool result = true; // будем считать, что по умолчанию строка - ссылка

            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
                result = false;

            return result;
        } // UrlValidator
    }


    // вспомогательный класс для импорта книг
    // потребовался доп. класс, так как данные в JSON хранятся в виде одного обьекта,
    // а нам нужно разные свойства присвоить разным обьектам
    [DataContract]
    public class ImportingBook {
        [DataMember]
        public string Author { get; set; }
        [DataMember]
        public string CoverUrl { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string Gener { get; set; }
        [DataMember]
        public string PublishYear { get; set; }
        [DataMember]
        public string Title { get; set; }
    }
}
