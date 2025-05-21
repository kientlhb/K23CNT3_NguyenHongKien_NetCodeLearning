using System.Diagnostics;
using lesson05.Models;
using lesson05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace lesson05.Controllers
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
            NhkMember nhkMember = new NhkMember();
            nhkMember.NhkMemberId = Guid.NewGuid().ToString();
            nhkMember.NhkUserName = "NguyenKien";
            nhkMember.NhkPassWord = "123456";   
            nhkMember.NhkFullName = "Nguyen Hong Kien";
            nhkMember.NhkEmail = "Kientlhb3@gmail.com";
            return View(nhkMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
