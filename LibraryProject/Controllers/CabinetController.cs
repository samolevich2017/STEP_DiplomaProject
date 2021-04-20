using LibraryProject.Models;
using LibraryProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace LibraryProject.Controllers {
    

    public class CabinetController : Controller {
        public Readers currentUserReader; // текущий юзер
        ApplicationContext context = new ApplicationContext();

        public IActionResult Cabinet(Readers currentUserReader) {
            if(Request.Cookies["authorizeUserCode"] != null) {
            
                // пытаемся получить id
                int? id = Convert.ToInt32(Request.Cookies["authorizeUserCode"]);
                if (id != null) {
                    currentUserReader = context.Readers.Find(id);
                    ViewBag.IsReadingCount = context.ReadersShelfs.Select(o => o).Where(s => s.IdReader == id && s.IdCategoryShelf == 4).ToList().Count;
                    ViewBag.ReadCount = context.ReadersShelfs.Select(o => o).Where(s => s.IdReader == id && s.IdCategoryShelf == 1).ToList().Count;
                    ViewBag.PendingCount = context.ReadersShelfs.Select(o => o).Where(s => s.IdReader == id && s.IdCategoryShelf == 3).ToList().Count;
                    return View(currentUserReader);
                }
                
            }
            return View("Authorization");
        }

        [HttpGet]
        public IActionResult Authorization() {
            // пытаемся получить id
            int? id = Convert.ToInt32(Request.Cookies["authorizeUserCode"]);
            if(id != null) {
                currentUserReader = context.Readers.Find(id);
                return RedirectToAction("Cabinet", currentUserReader);
            }
            return View();
        }

        [HttpPost]
        public IActionResult Authorization(string email, string password) {

            // проверяем не пустые ли поля
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password)) {
                return RedirectToAction("Authorization");
            }

            // находим читателя с данными введенными при авторизации
            currentUserReader = context.Readers.Select(o => o).Where(r => r.EmailReader == email && r.PasswordReader == password).FirstOrDefault();

            // если пользователь найден, записываем его уникальный код в куки
            if(currentUserReader != null) {

                // записываем данные в куки
                HttpContext.Response.Cookies.Delete("authorizeUserCode");
                HttpContext.Response.Cookies.Append("authorizeUserCode", currentUserReader.Id.ToString());

                // пускаем в кабинет
                return RedirectToAction("Cabinet", currentUserReader);
            }


            return RedirectToAction("Authorization");
        }

        // метод выхода из аккаунта
        public IActionResult LogOutCabinet() {
            HttpContext.Response.Cookies.Delete("authorizeUserCode"); // удаляем куки об авторизованном пользователе
            return LocalRedirect(Url.Action("Index", "Home"));
        }

        // регистрация пользователей
        [HttpGet]
        public IActionResult Register(string message = "") {
            ViewBag.Message = message;
            return View();
        } // Register

        [HttpPost]
        public IActionResult Register(string email, string password, string surnameNP, string login) {
            if(!string.IsNullOrWhiteSpace(email) || !string.IsNullOrWhiteSpace(password) || !string.IsNullOrWhiteSpace(surnameNP) || !string.IsNullOrWhiteSpace(login)) {
                
                if(context.Readers.Select(o=>o).Where(r=>r.EmailReader == email).ToList().Count > 0) {
                    string mess = new String("Пользователь с таким Email уже существует!");
                    return RedirectToRoute("default", new { controller="Cabinet", action = "Register", method = "GET", message = mess });
                }

                if (context.Readers.Select(o => o).Where(r => r.LoginReader == login).ToList().Count > 0) {
                    string mess = new String("Пользователь с таким логином уже существует!");
                    return RedirectToRoute("default", new { controller = "Cabinet", action = "Register", method = "GET", message = mess });
                }

                List<string> fio = surnameNP.Split(" ").ToList();
                
                // создаем обьект читателя (пользователя)
                Readers reader = new Readers {
                    SurnameReader = fio[0],
                    NameReader = fio[1],
                    PatronymicReader = fio[2],
                    LoginReader = login,
                    EmailReader = email,
                    PasswordReader = password,
                    PhotoReaderUrl = @"https://st.depositphotos.com/1779253/5140/v/600/depositphotos_51405259-stock-illustration-male-avatar-profile-picture-use.jpg",
                    AdressReader = "Не установлено",
                    PhoneNumberReader = "Не установлено"
                };
                
                // если все хорошо добавляем в базу
                if(reader != null) {
                    context.Readers.Add(reader);
                    context.SaveChanges();
                }

                return RedirectToAction("Authorization");
            }
            return RedirectToAction("Register");
        } // Register

        // раздел - мои книги
        public IActionResult MyBooks() {
            int? id = Convert.ToInt32(Request.Cookies["authorizeUserCode"]);
            return PartialView(context.Readers.Find(id));
        }

        // раздел - безопасность
        public IActionResult Security() {
            int? id = Convert.ToInt32(Request.Cookies["authorizeUserCode"]);
            return PartialView(context.Readers.Find(id));
        }

        // метод для смены пароля пользователя
        [HttpPost]
        public void ChangePassword(string currentPassword, string newPassword, string confirmNewPassword) {
            int? id = Convert.ToInt32(Request.Cookies["authorizeUserCode"]);
            currentUserReader = context.Readers.Find(id);
            // если введен верный текущий пароль - производим смену
            if (currentUserReader.PasswordReader == currentPassword) {
                if(newPassword == confirmNewPassword) {
                    context.Readers.Find(id).PasswordReader = newPassword;
                    context.SaveChanges();
                } // if
            } // if
        } // ChangePasswors

        // метод добавления\изменения доп. информации (адреса и номера телефонов)
        [HttpPost]
        public void ChangeExtInformation(string adress, string phone) {
            int? id = Convert.ToInt32(Request.Cookies["authorizeUserCode"]);

            if(!string.IsNullOrEmpty(adress) || !string.IsNullOrEmpty(phone)) {
                context.Readers.Find(id).AdressReader = adress;
                context.Readers.Find(id).PhoneNumberReader = phone;
                context.SaveChanges();
            } // if

        } // ChangeExtInformation

        // метод для переадрессацию на страницу с подробной инфой о книге
        public IActionResult CabinetDetailsBook(string id) {
                Books selectedBook = context.Books.Find(Convert.ToInt32(id));
            
                List<BooksGenres> listBookGenres = context.BooksGenres.Select(o => o).Where(b => b.BookId == selectedBook.Id).ToList();
                List<string> listGenresCurrentBook = new List<string>();
                foreach (var item in listBookGenres) {
                    listGenresCurrentBook.Add(context.Genres.Where(g => g.Id == item.GenreId).ToList()[0].GenreName.ToString());
                }

                ViewBag.Genres = listGenresCurrentBook;
                BooksEditViewModel booksEditViewModel = new BooksEditViewModel(selectedBook);
                return PartialView(booksEditViewModel);
          
        }
    } 
}
