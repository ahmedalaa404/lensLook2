using lensLook.Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lensLook.Dal
{
    public interface IBasketRepo
    {
        // 3- Methode


        // return basket

        //Task<BasketCustomer?> GetBasketCustomer(int id);

        //Task<BasketCustomer> UpdateBasket(BasketCustomer Basket); //Create Or Update
        //  bool DeleteBasket(BasketCustomer customer);


        public BasketCustomer GetCustomerBasket(string IdUser);
        public bool UpdateBasket(BasketCustomer NewBasket);

        public int GetCountBasketItems(string IdUser);
    }



}

