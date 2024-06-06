namespace Souq.Core.Repositories
{
    public interface IBasketRepo
    {
        //Task<CustomerBasket> GetBasketAsync(string Id);

        //Task<CustomerBasket?> UpdateBasketAsync(CustomerBasket Basket); //Update And Create 



        Task<bool> DeleteBasketAsync(string Id);



    }
}
