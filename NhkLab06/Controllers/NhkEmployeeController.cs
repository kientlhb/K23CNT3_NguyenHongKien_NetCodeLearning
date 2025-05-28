using Microsoft.AspNetCore.Mvc;
using NhkLab06.Models;

namespace NhkLab06.Controllers
{
    public class NhkEmployeeController : Controller
    {
        private static List<NhkEmployee> NhkListEmployee = new List<NhkEmployee>()
{
    new NhkEmployee {
        NhkId = 1,
        NhkName = "Nguyễn Hong Kien",
        NhkBirthDay = new DateTime(2005, 11, 02),
        NhkEmail = "Kientlhb3@Gmail.com",
        NhkPhone = "09426892616",
        NhkSalary = 1200.50,
        NhkStatus = true
    },
    new NhkEmployee {
        NhkId = 2,
        NhkName = "Trần Thị B",
        NhkBirthDay = new DateTime(1985, 10, 15),
        NhkEmail = "tranthib@example.com",
        NhkPhone = "0912345678",
        NhkSalary = 1500,
        NhkStatus = true
    },
    new NhkEmployee {
        NhkId = 3,
        NhkName = "Lê Văn C",
        NhkBirthDay = new DateTime(1992, 12, 1),
        NhkEmail = "levanc@example.com",
        NhkPhone = "0987654321",
        NhkSalary = 1000,
        NhkStatus = false
    },
    new NhkEmployee {
        NhkId = 4,
        NhkName = "Phạm Thị D",
        NhkBirthDay = new DateTime(1995, 3, 10),
        NhkEmail = "phamthid@example.com",
        NhkPhone = "0978123456",
        NhkSalary = 1100,
        NhkStatus = true
    }
};
        public IActionResult NhkIndex()
        {
            return View(NhkListEmployee);
        }

        public IActionResult NhkCreate()
        {
            return View();
        }
    }
}
