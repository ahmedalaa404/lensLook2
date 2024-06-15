
using lensLook.Dal.Models;

namespace lensLook.Dal
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(Order model);
        List<Order> GetOrdersForUser(string UserId);

        public bool RemoveOrder(int x);
        Order GetOrderById(int OrderId);
    }
}
