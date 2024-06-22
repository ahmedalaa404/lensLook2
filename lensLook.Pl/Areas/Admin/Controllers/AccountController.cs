using lensLook.Bll;
using lensLook.Dal;
using lensLook.Dal.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace lensLook.Pl.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AccountController : Controller
    {
        private readonly UserManager<user> usermanager;
        private readonly IOrderService _orderServies;
        private readonly IServicesRepo ServiesRepo;

        public AccountController(UserManager<user> usermanager , IOrderService OrderServies, IServicesRepo _ServiesRepo)
        {
            this.usermanager = usermanager;
            _orderServies = OrderServies;
            ServiesRepo = _ServiesRepo;
        }
        public IActionResult User() 
        {
            var Alluser = usermanager.Users.ToList();
            return View(Alluser);
        }

        public IActionResult RegisterNewPatient()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult RegisterNewPatient()
        //{
        //    return View();
        //}
    }
}
