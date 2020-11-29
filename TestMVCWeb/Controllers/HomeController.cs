using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TestMVCWeb.Models;

namespace TestMVCWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var firstUser = new User
            {
                No = 1,
                Name = "윤종섭"
            };

            // # 1. View(object) 이용
            return View(firstUser);
        }

        public IActionResult Privacy()
        {
            var firstUser = new User
            {
                No = 2,
                Name = "개인정보"
            };

            // # 2. ViewBag 사용
            ViewBag.Bag = firstUser;
            return View();
        }

        public IActionResult Test()
        {
            var firstUser = new User
            {
                No = 3,
                Name = "테스터"
            };

            // # 3. ViewData 사용
            ViewData["No"] = firstUser.No;
            ViewData["Name"] = firstUser.Name;
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
