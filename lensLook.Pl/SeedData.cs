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
                    Fname = "Ahmed",
                    Lname="Alaa",
                    Email = "test@mail.com",
                    UserName = "HambozoCom",
                    DisplayName="Hambozo11"
                };
             var resulte=  await _userManager.CreateAsync(model, "Hambozo123@@##");

            }

        }

        #endregion
    }
}
