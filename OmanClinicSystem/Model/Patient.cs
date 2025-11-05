using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicSystem.Model
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string Name { get; set; }
        public string NationalID { get; set; }
        public string PhoneNumber { get; set; }

        public Patient(int id, string name, string nationalId, string phone)
        {
            PatientID = id;
            Name = name;
            NationalID = nationalId;
            PhoneNumber = phone;
        }
    }

}
