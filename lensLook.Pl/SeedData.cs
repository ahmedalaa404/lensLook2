using lensLook.Dal.Models;
using Microsoft.AspNetCore.Identity;
using System.Text.Json;

namespace lensLook.Pl
{
    public static class SeedData
    {
        #region Seed Data ( Brands)
        public static async Task Seed(UserManager<user> _userManager)
        {

            if (!_userManager.Users.Any())
            {
                user model = new user()
                {
                    FirstName = "Ahmed",
                    LastName="Alaa",
                    Email = "test@mail.com",
                    UserName = "HambozoCom",
                    DisplayName="Hambozo11",
                    BasketCustomers=new BasketCustomer()
                    {
                        
                    }
                };
             var resulte=  await _userManager.CreateAsync(model, "Hambozo123@@##");

            }

        }

        #endregion
    }
}
