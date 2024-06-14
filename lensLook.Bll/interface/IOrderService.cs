
using lensLook.Dal.Models;
using lensLook.Pl.Models;

namespace lensLook.Dal
{
    public interface IOrderService
    {
        Task<Order> CreateOrderAsync(Order model);
        List<Order> GetOrdersForUser(string UserId);


        Order GetOrderById(int OrderId);
    }
}
