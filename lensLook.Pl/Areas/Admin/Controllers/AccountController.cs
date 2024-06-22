using lensLook.Bll;
using lensLook.Dal;
using lensLook.Dal.Models;
using lensLook.Pl.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Claims =Microsoft.AspNetCore.Mvc;

using System.Security.Claims;


namespace lensLook.Pl.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
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
        public IActionResult Users()
        {
            var userId= User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var Alluser = usermanager.Users.Where(x=>x.Id!=userId).ToList();
            return View(Alluser);
        }



        [HttpGet]
        public IActionResult DeleteUser(string id)
        {
           if(!string.IsNullOrEmpty(id))
            {
                var user=usermanager.Users.FirstOrDefault(x => x.Id == id);
                if (user != null)
                {
                    return View(user);

                }
            }

           return RedirectToAction(nameof(Index));
        }    
        
        
        
        [HttpPost]
        public async Task<IActionResult> DeleteUser(user Model)
        {
           if(!string.IsNullOrEmpty(Model.Id))
            {
                var user=usermanager.Users.FirstOrDefault(x => x.Id == Model.Id);
                if (user != null)
                {
                await  usermanager.DeleteAsync(user);

                }
            }

            return RedirectToAction("Index", "Account", new { area = "Admin" });
        }






       [HttpGet]
        public IActionResult RegisterNewPatient()
        {
            return View();
        }       
        
        
        
        
        [HttpPost]
        public IActionResult RegisterNewPatient(RegisterVM Model)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }      
        

            
        
        [HttpGet]
        public IActionResult RegisterNewDoctor()
        {
            return View();
        }       
        
        
        
        
        [HttpPost]
        public IActionResult RegisterNewDoctor(RegisterVM Model)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }      
        






    }
}
