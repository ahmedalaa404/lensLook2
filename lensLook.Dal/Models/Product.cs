using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lensLook.Dal.models
{
    public class Product
    {


        public int Id { get; set; }
        [Required]

        public string  Name { get; set; }

        public string  Description { get; set; }

        public string PictureUrl { get; set; } // Name Picture


        public decimal Price { get; set; }




    }
}
