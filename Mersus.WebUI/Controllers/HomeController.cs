using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mersus.WebUI.Models;
using Mersus.Core.Interfaces;

namespace Mersus.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IUserRepo _userRepository;
      
        public HomeController(ILogger<HomeController> logger, IUserRepo userRepository)
        {
             _userRepository = userRepository;
            _logger = logger;
        }

        public IActionResult Index()
        {
        
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

        public IActionResult GetUsers()
        {
            return Json(_userRepository.GetAll());
        }
    }
}
