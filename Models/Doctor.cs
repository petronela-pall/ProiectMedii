using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMedii.Models
{
    public class Doctor
    {
        public int ID { get; set; }
        public string DoctorName { get; set; }
        public string DoctorSpecialty { get; set; }
        public ICollection<Appointment> Appointments { get; set; }

    }
}
