using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lensLook.Dal.Models
{
    public class Services
    {

            public int Id { get; set; }
            public BookingType BookingType { get; set; }
            public string? Address { get; set; } // Address for home and repair appointments


            public ICollection<Booking> Bookings { get; set; } = new HashSet<Booking>();
        }
        public enum BookingType
        {
            HomeVisit,
            Online,
            Repairs
        }

    }

