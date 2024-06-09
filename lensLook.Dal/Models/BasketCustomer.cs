using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lensLook.Dal.Models
{
    public class BasketCustomer
    {
        [Key]
        public int Id { get; set; }


        public string UserId { get; set; }
        public user user { get; set; }


        public BasketCustomer(int id)
        {
            Id = id;
        }

        public BasketCustomer()
        {

        }

        public Collection<BasketItems>? BasketItems { get; set; }




    }



  









}
