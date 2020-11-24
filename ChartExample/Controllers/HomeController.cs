using ChartExample.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChartExample.Controllers
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
            var chart = new ChartDataModel<CharItem>()
            {
                Title = "Districts",
                ChartDataList = new List<CharItem>
            {
                new CharItem
                {
                    Name = "Жалал-Абад",
                    Value = 12345
                },
                new CharItem
                {
                    Name = "Бишкек",
                    Value = 54321
                },
                new CharItem
                {
                    Name = "Ош",
                    Value = 23456
                },
            }
            };
            return View(chart);
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
