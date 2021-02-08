using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WTS_CodingTest.Managers;
using WTS_CodingTest.Models;

namespace WTS_CodingTest.Controllers
{
    public class HomeController : Controller
    {

        private IShiftManager _shiftManager;

        public HomeController(IShiftManager shiftManager)
        {
            _shiftManager = shiftManager;
        }

        public IActionResult Index()
        {
            List<DisplayData> data = _shiftManager.GetDisplayData();
            ViewBag.DisplayItems = data;
            return View();
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
