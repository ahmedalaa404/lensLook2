using lensLook.Dal;
using lensLook.Dal.Context;
using lensLook.Dal.Models;
using lensLook.Pl.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lensLook.Bll.Services
{
    public class OrderService : IOrderService
    {
        private readonly LensLookDbContext _context;

        public OrderService(LensLookDbContext Context)
        {
            _context = Context;
        }

        public async Task<Order> CreateOrderAsync(Order model)
        {
           await _context.Order.AddAsync(model);
            var Basket=_context.BasketCustomers.FirstOrDefault(x=>x.UserId==model.UserIdCreateOrder);

            model.SubTotal=model.Items.Sum(x=>x.Price*x.Quantity)+10;
            Basket.BasketItems.Clear();
            _context.BasketCustomers.Update(Basket);
            _context.SaveChanges();
            return model;
        }

        public Order GetOrderById(int OrderId)
        {
            var Order= _context.Order.Where(x => x.Id == OrderId).Include(x => x.Items).FirstOrDefault();

            return Order;
        }

        public List<Order> GetOrdersForUser(string UserId)
        {
            return _context.Order.Where(x => x.UserIdCreateOrder == UserId).Include(x=>x.Items).ToList();
        }




        public bool RemoveOrder(int x )
        {
            try
            {
                _context.Order.Remove(GetOrderById(x));
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }







    }
}
