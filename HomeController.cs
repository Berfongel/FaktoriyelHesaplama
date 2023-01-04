using FaktöriyelHesabiWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FaktöriyelHesabiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(FaktöriyelHesabi faktöriyelHesabi)
        {
            var messageFöktöriyel = string.Empty;
            //girilen sayı
            var sayi = faktöriyelHesabi.Faktöriyel;
            var islem = 1;
            for (int n=1;n<=sayi;n++)
            {                                                                                                                                                                                                                                
                islem = islem * n;

                ViewBag.Message = "Girilen Sayının Faktöriyeli : " + islem;
            }


            return View("faktöriyelHesabi");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}