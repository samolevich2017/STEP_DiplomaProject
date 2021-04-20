using LibraryProject.Models;
using LibraryProject.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryProject.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }

        // страница "Контакты"
        public IActionResult Contacts() {
            return View();
        }

        // страница "О нас"
        public IActionResult AboutUS() {
            return View();
        }

        // страницы "Авторизация"
        public IActionResult Authorization() {
            return View();
        }

        // Метод отправки сообщения с формы на странице "Контакты"
        [HttpPost]
        public async Task<IActionResult> SendMessage(string emailClient, string nameClient, string telClient, string messageClient) {
            EmailService emailService = new EmailService();
            await emailService.SendEmailAsync(emailClient, nameClient, telClient, messageClient);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
