using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicSystem.Model
{
    public class Doctor
    {
        public int DoctorID { get; set; }
        public string Name { get; set; }
        public string Specialty { get; set; }
        public string PhoneNumber { get; set; }

        public Doctor(int id, string name, string specialty, string phone)
        {
            DoctorID = id;
            Name = name;
            Specialty = specialty;
            PhoneNumber = phone;
        }
    }
}
