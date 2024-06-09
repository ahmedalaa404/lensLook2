using lensLook.Dal;
using lensLook.Dal.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace lensLook.Pl.Controllers
{
    public class BasketController : Controller
    {
        private readonly IBasketRepo _basketRepo;
        private readonly UserManager<user> userManager;
        private readonly IProductRepo productRepo;

        public BasketController(IBasketRepo BasketRepo, UserManager<user> userManager, IProductRepo productRepo)
        {
            _basketRepo = BasketRepo;
            this.userManager = userManager;
            this.productRepo = productRepo;
        }



        [Authorize]
        public async Task<IActionResult> AddToCart(int Product)
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (userId == null)
            {
                return Unauthorized();
            }

            var OldBasket = _basketRepo.GetCustomerBasket(userId);

            var x = OldBasket.BasketItems.Where(x => x.Productid == Product).FirstOrDefault();
            if (x != null)
            {
                x.Quantity++;
            }
            else
            {
                var product = productRepo.GetProductById(Product);
                OldBasket.BasketItems.Add(new BasketItems
                {
                    Productid = Product,
                    Quantity = 1,
                    Photo = product.Image,
                    price = product.Price,
                    Name = product.Name,
                });

            }

            var StateUpdateOrDelete = _basketRepo.UpdateBasket(OldBasket);

            return RedirectToAction("store", "Home");


        }




        //[HttpGet]
        //public async Task<IActionResult> GetCustomerBasket(int Id)
        //{
        //    var Basket = await _basketRepo.GetBasketCustomer(Id);
        //    if (Basket is null)
        //    {
        //        return View(Basket);
        //    }
        //    else
        //    {
        //        var BasketNewTheSameOldBaasketWithoutData=new BasketCustomer(Id);

        //        return View(Basket);
        //    }


        //}





        //[HttpPost]

        //public async Task<IActionResult> UpdateBasket(BasketCustomer basket)
        //{
        //    //var Basket = await _basketRepo.GetBasketCustomer(Id);

        //    var CreateorUpdate = await _basketRepo.UpdateBasket(basket);
        //    if (CreateorUpdate is null)
        //    {
        //        return RedirectToAction("index", "Home");
        //    }

        //    return View(CreateorUpdate);

        //}





        //[HttpGet]
        //public async Task<IActionResult> Delete(int BasketId)
        //{
        //    var basket =await _basketRepo.GetBasketCustomer(BasketId);
        //          _basketRepo.DeleteBasket(basket);
        //    return RedirectToAction("index", "Home");

        //}
    }
}
