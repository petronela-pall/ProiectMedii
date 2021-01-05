using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMedii.Models
{
    public class Appointment
    {
        public int ID { get; set; }

        [Display(Name = "Owner Name")]
        public string ClientName { get; set; }

        [Display(Name = "Pet Name")]
        public string PetName { get; set; }
        public DateTime ApptTime { get; set; }

        public int DoctorID { get; set; }
        public Doctor Doctor { get; set; }

        public int CategoryID { get; set; }
        public Category Category { get; set; }


        //public ICollection<Category> Categories { get; set; }

    }
}
