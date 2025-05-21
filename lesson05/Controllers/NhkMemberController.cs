using lesson05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace lesson05.Controllers
{
    public class NhkMemberController : Controller
    {
        private static List<NhkMember> nhkListMembers = new List<NhkMember>
        {
            new NhkMember
            {
                NhkMemberId = "2310900055",
                NhkUserName = "NguyenKien",
                NhkPassWord = "123456",
                NhkFullName = "Nguyen Hong Kien",
                NhkEmail = "Kientlhb3@gmail.com"
            },
            new NhkMember
            {
                NhkMemberId = "M002",
                NhkUserName = "user2",
                NhkPassWord = "pass2",
                NhkFullName = "Tran Thi B",
                NhkEmail = "user2@example.com"
            },
            new NhkMember
            {
                NhkMemberId = "M003",
                NhkUserName = "user3",
                NhkPassWord = "pass3",
                NhkFullName = "Le Van C",
                NhkEmail = "user3@example.com"
            },
            new NhkMember
            {
                NhkMemberId = "M004",
                NhkUserName = "user4",
                NhkPassWord = "pass4",
                NhkFullName = "Pham Thi D",
                NhkEmail = "user4@example.com"
            },
            new NhkMember
            {
                NhkMemberId = "M005",
                NhkUserName = "user5",
                NhkPassWord = "pass5",
                NhkFullName = "Hoang Van E",
                NhkEmail = "user5@example.com"
            }
        };
        public IActionResult NhkIndex()
        {
            return View(nhkListMembers);
        }
    }
}
