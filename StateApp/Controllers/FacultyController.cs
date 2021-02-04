using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StateApp.Models;

namespace StateApp.Controllers
{
    public class FacultyController : Controller
    {
        private readonly ILogger<FacultyController> _logger;

        public FacultyController(ILogger<FacultyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Отображение страниц со списком сущностей

        public IActionResult StudentsPage()
        {
            return View();
        }

        public IActionResult GroupsPage()
        {
            return View();
        }

        public IActionResult DisciplinesPage()
        {
            return View();
        }

        public IActionResult ProfessorsPage()
        {
            return View();
        }

        #endregion

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
