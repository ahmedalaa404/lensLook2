using AutoMapper;
using lensLook.Bll;
using lensLook.Bll.Services;
using lensLook.Dal.Models;
using lensLook.Pl.Models.BookingViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace lensLook.Pl.Controllers
{
    public class BookingController : Controller
    {
        private readonly IMapper _mapperConfig;
        private readonly IServicesRepo servicesReop;
        private readonly IRequestServices _RequestService;

        public BookingController(IMapper mapperConfig, IServicesRepo servicesReop, IRequestServices requestService)
        {
            _mapperConfig = mapperConfig;
            this.servicesReop = servicesReop;
            _RequestService = requestService;
        }

        [HttpGet]
        public IActionResult Repair()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Repair(BookingCreateVm model)
        {
            if (ModelState.IsValid)
            {

                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (userId == null)
                {
                    return Unauthorized();
                }

                var RequestServices = _mapperConfig.Map<Booking>(model);
                RequestServices.UserId = userId;
                var ServicesType = servicesReop.GetByName("repairs");
                RequestServices.ServiceId = ServicesType.Id;

                var Resulte = _RequestService.Create(RequestServices);

                if (!Resulte)
                    return View();
                return RedirectToAction("Index", "Home");

            }

            return View();
        }

        public IActionResult Online()
        {
            return View();
        }



        [HttpPost]
        public IActionResult Online(BookingCreateVm model)
        {
            if (ModelState.IsValid)
            {

                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (userId == null)
                {
                    return Unauthorized();
                }

                var RequestServices = _mapperConfig.Map<Booking>(model);
                RequestServices.UserId = userId;
                var ServicesType = servicesReop.GetByName("Online");
                RequestServices.ServiceId = ServicesType.Id;

                var Resulte = _RequestService.Create(RequestServices);

                if (!Resulte)
                    return View();
                return RedirectToAction("Index", "Home");

            }
            return View();



        }









        public IActionResult offline()
        {
            return View();
        }






        [HttpPost]
        public IActionResult offline(BookingCreateVm model)
        {
            if (ModelState.IsValid)
            {

                var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (userId == null)
                {
                    return Unauthorized();
                }

                var RequestServices = _mapperConfig.Map<Booking>(model);
                RequestServices.UserId = userId;
                var ServicesType = servicesReop.GetByName("HomeVisit");
                RequestServices.ServiceId = ServicesType.Id;

                var Resulte = _RequestService.Create(RequestServices);

                if (!Resulte)
                    return View();
                return RedirectToAction("Index", "Home");

            }
            return View();
        }



        public IActionResult AllBookingForUser()
        {

            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return Unauthorized();
            }
         var AllRequests=   _RequestService.GetServicesByUser(userId);
            return View(AllRequests);
        }




    }
}
