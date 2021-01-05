using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMedii.Models
{
    public class Category
    {
        public int ID { get; set; }

        [Display(Name = "Service Name")]
        public string CategoryName { get; set; }

        [Display(Name = "Price")]
       
        public int ServicePrice { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
