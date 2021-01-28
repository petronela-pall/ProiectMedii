using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectMedii.Models
{
    public class Doctor
    {
        public int ID { get; set; }

        [Display(Name = "Doctor Name")]
        public string DoctorName { get; set; }

        [Display(Name = "Doctor Specialty")]
        public string DoctorSpecialty { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
