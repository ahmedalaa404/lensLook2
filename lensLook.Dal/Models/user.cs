using Microsoft.AspNetCore.Identity;

namespace lensLook.Dal.Models
{
    public class user : IdentityUser
    {
        public string DisplayName { get; set; }
        public bool IsAgree { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
    }
}
