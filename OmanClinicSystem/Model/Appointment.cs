using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicSystem.Model
{
    public class Appointment
    {
        [Key]
        public int Appointment_ID { get; set; }

        [ForeignKey(nameof(Patient))]
        public int Patient_ID { get; set; }
        public Patient Patient { get; set; }

        [ForeignKey(nameof(Doctor))]
        public int Doctor_ID { get; set; }
        public Doctor Doctor { get; set; }

        public DateOnly Date { get; set; }

        public Appointment(int appointment_ID, Patient patient, Doctor doctor, DateOnly date)
        {
            Appointment_ID = appointment_ID;
            Patient = patient;
            Doctor = doctor;
            Date = date;
        }

    }
}
