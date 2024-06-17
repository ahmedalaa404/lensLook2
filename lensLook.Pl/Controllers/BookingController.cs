using lensLook.Dal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace lensLook.Pl.Controllers
{
    [Authorize]
    public class BookingController : Controller
    {

        [HttpGet]
        public IActionResult Repair()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Repair(Booking model)
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            return View();
        }







    }
}
