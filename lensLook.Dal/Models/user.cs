using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lensLook.Dal.Models
{
    public class user : IdentityUser
    {
        public string DisplayName { get; set; }
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name Is Required")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }


        public bool IsActive { get; set; }


        public int? Experience { get; set; }

        [Required]
        public string? Specialization { get; set; }

        public int? NumberOfAppointments { get; set; }

        [DataType(DataType.Currency)]
        public decimal? Salary { get; set; }
        [Required]
        public string? MedicalLicenseNumber { get; set; }
        [Required]
        public string? HomeAddress { get; set; }
        [Required]
        public string? image { get; set; }

        public string RoleName { get; set; }








        public BasketCustomer BasketCustomers { get; set; }




        public ICollection<Booking> UserBooking { get; set; } = new HashSet<Booking>();
        public ICollection<Booking> DoctorBooking { get; set; } = new HashSet<Booking>();
        public ICollection<Booking> AdminBooking { get; set; } = new HashSet<Booking>();



    }
}
