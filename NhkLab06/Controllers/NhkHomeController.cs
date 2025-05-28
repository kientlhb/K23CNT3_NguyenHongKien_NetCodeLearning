using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using NhkLab06.Models;

namespace NhkLab06.Controllers
{
    public class NhkHomeController : Controller
    {
        private readonly ILogger<NhkHomeController> _logger;

        public NhkHomeController(ILogger<NhkHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult NhkIndex()
        {
            return View();
        }

        public IActionResult NhkAbout()
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
