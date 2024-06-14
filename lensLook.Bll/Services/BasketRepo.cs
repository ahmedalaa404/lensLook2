using lensLook.Dal;
using lensLook.Dal.Context;
using lensLook.Dal.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lensLook.Bll.Services
{
    public class BasketRepo : IBasketRepo
    {
        private readonly LensLookDbContext _context;

        public BasketRepo(LensLookDbContext Context)
        {
            _context = Context;
        }

        public int GetCountBasketItems(string IdUser)
        {
            var BasketItem = _context.BasketCustomers.Include(x => x.BasketItems).Where(x => x.UserId == IdUser).FirstOrDefault();

            return BasketItem.BasketItems.Count();
        }

        public BasketCustomer GetCustomerBasket(string IdUser)
        {

            return _context.BasketCustomers.Include(x => x.BasketItems).ThenInclude(x=>x.Product).FirstOrDefault(x => x.UserId == IdUser);

        }
        public BasketCustomer GetCustomerBasketWithProduct(string IdUser)
        {

            return _context.BasketCustomers.Include(x => x.BasketItems).ThenInclude(x => x.Product).FirstOrDefault(x => x.UserId == IdUser);

        }





		public BasketCustomer GetCustomerBasketWithProductById(int Customerbasket)
		{

			return _context.BasketCustomers.Include(x => x.BasketItems).ThenInclude(x => x.Product).FirstOrDefault(x => x.Id == Customerbasket);

		}




		public bool UpdateBasket(BasketCustomer NewBasket)
        {
            try
            {
                _context.BasketCustomers.Update(NewBasket);
                _context.BasketItems.Where(x => x.CustomerBasketId == null && x.Productid == NewBasket.Id);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }

        }
        //public bool DeleteBasket(BasketCustomer customer)
        //{
        //    try
        //    {
        //        _context.BasketCustomers.Remove(customer);
        //        _context.SaveChanges();
        //        return true;

        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //        throw;
        //    }


        //}

        //public async Task<BasketCustomer?> GetBasketCustomer(int id)
        //{

        //    var Basket1=   await  _context.BasketCustomers.Where(x => x.Id == id).FirstOrDefaultAsync();


        //    return (Basket1 ==null)? null : Basket1;


        //} 

        //public async Task<BasketCustomer?> UpdateBasket(BasketCustomer Basket)
        //{
        //    if(Basket.Id!=null)
        //    {
        //        _context.BasketCustomers.Update(Basket);
        //        return await _context.BasketCustomers.Where(x => x.Id == Basket.Id).FirstOrDefaultAsync();
        //    }
        //    else
        //    {
        //        _context.BasketCustomers.Add(Basket);
        //        return null;
        //    }

        //}




    }

}
