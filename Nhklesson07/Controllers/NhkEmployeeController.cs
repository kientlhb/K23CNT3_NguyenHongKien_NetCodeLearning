using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nhklesson07.Models;

namespace Nhklesson07.Controllers;

public class NhkEmployeeController : Controller
{
    private static List<NhkEmployee> nhkListEmployee = new List<NhkEmployee>() 
    {
         new NhkEmployee
        {
            NhkId = 2310900055,
            NhkName = "Nguyen Hong Kien",
            NhkBirthDay = new DateTime(2005, 11, 02),
            NhkEmail = "Kientlhb3@gmail.com",
            NhkPhone = "0946892616",
            NhkSalary = 15000000,
            NhkStatus = true
        },
        new NhkEmployee
        {
            NhkId = 2,
            NhkName = "Tran Thi B",
            NhkBirthDay = new DateTime(1988, 8, 15),
            NhkEmail = "thib@example.com",
            NhkPhone = "0934567890",
            NhkSalary = 18000000,
            NhkStatus = false
        },
        new NhkEmployee
        {
            NhkId = 3,
            NhkName = "Le Van C",
            NhkBirthDay = new DateTime(1992, 3, 10),
            NhkEmail = "vanc@example.com",
            NhkPhone = "0909988776",
            NhkSalary = 14000000,
            NhkStatus = true
        },
        new NhkEmployee
        {
            NhkId = 4,
            NhkName = "Pham Thi D",
            NhkBirthDay = new DateTime(1995, 11, 25),
            NhkEmail = "thid@example.com",
            NhkPhone = "0977112233",
            NhkSalary = 16000000,
            NhkStatus = true
        },
        new NhkEmployee
        {
            NhkId = 5,
            NhkName = "Do Van E",
            NhkBirthDay = new DateTime(1985, 1, 5),
            NhkEmail = "vane@example.com",
            NhkPhone = "0966554433",
            NhkSalary = 20000000,
            NhkStatus = false
        }
    };
    // GET: NhkEmployeeController

    public ActionResult NhkIndex()
    {
        return View(nhkListEmployee);
    }

    // GET: NhkEmployeeController/NhkDetails/5
    public ActionResult NhkDetails(int id)
    {
        var nhkEmployee = nhkListEmployee.FirstOrDefault(x => x.NhkId == id);

        return View(nhkEmployee);
    }

    // GET: NhkEmployeeController/NhkCreate
    public ActionResult NhkCreate()
    {
        var nhkEmployee = new NhkEmployee();
        return View(nhkEmployee);
    }

    // POST: NhkEmployeeController/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult NhkCreate(NhkEmployee nhkModel)
    {
        try
        {
            nhkModel.NhkId = nhkListEmployee.Max(x => x.NhkId) + 1;
            nhkListEmployee.Add(nhkModel);
            return RedirectToAction(nameof(NhkIndex));
        }
        catch
        {
            return View();
        }
    }

    // GET: NhkEmployeeController/NhkEdit/5
    public ActionResult NhkEdit(int id)
    {
        var nhkEmployee = nhkListEmployee.FirstOrDefault(x => x.NhkId == id);
        if (nhkEmployee == null)
        return View(nhkEmployee);
        {
            // Có thể trả về NotFound hoặc chuyển hướng về trang danh sách
            return NotFound();
            // hoặc return RedirectToAction("NhkIndex");
        }
    }

    // POST: NhkEmployeeController/NhkEdit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult NhkEdit(int id, NhkEmployee nhkModel)
    {
        try
        {
            for (int i = 0; i < nhkListEmployee.Count; i++)
            {
                if (nhkListEmployee[i].NhkId == id)
                {
                    nhkListEmployee[i] = nhkModel;
                    break;
                }
            }
            return RedirectToAction(nameof(NhkIndex));
        }
        catch
        {
            return View();
        }
    }

    // GET: NhkEmployeeController/Delete/5
    public ActionResult NhkDelete(int id)
    {
        var nhkEmployee = nhkListEmployee.FirstOrDefault(x => x.NhkId == id);
        return View(nhkEmployee);
    }

    // POST: NhkEmployeeController/Delete/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Delete(int id, NhkEmployee nhkModel)
    {
        try
        {
            var nhkEmployee = nhkListEmployee.FirstOrDefault(x => x.NhkId == id);
            if (nhkEmployee != null)
            {
                nhkListEmployee.Remove(nhkEmployee);
            }
            
            return RedirectToAction(nameof(NhkIndex));
        }
        catch
        {
            return View();
        }
    }
}
