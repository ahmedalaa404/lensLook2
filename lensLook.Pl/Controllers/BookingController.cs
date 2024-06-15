//using AutoMapper;
//using lensLook.Dal.Models;
//using Microsoft.AspNetCore.Mvc;

//namespace lensLook.Pl.Controllers
//{
//    public class BookingController : Controller
//    {
//        private readonly IUnitOfWork _unitOfWork;
//        private readonly IMapper _mapper;
//        public BookingController(IUnitOfWork unitOfWork,
//            IMapper mapper)
//        {

//            _unitOfWork = unitOfWork;
//            _mapper = mapper;
//        }

//        public IActionResult Appointment()
//        {
//            return View();
//        }
//        [HttpGet]
//        public async Task<IActionResult> HomeAppointment()
//        {
//            var Booking = await _unitOfWork.BookingRepo.GetAllAsync();
//            return View();
//        }
//        [HttpPost]
//        public async Task<IActionResult> HomeAppointment(BookingVM bookingVM, int UserId)
//        {
//            var MappedBooking = _mapper.Map<BookingVM, Booking>(bookingVM);
//            await _unitOfWork.BookingRepo.addasync(MappedBooking);
//            return View();
//        }
//    }
//}
