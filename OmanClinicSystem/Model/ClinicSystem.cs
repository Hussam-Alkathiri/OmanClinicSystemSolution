using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmanClinicSystem.Model
{
    public class ClinicSystem
    {
        private List<Patient> patients = new List<Patient>();
        private List<Doctor> doctors = new List<Doctor>();
        private List<Appointment> appointments = new List<Appointment>();
        private int patientCounter = 1;
        private int doctorCounter = 1;
        private int appointmentCounter = 1;

        public void PrintList()
        {
            while (true)
            {
                Console.WriteLine("\n============================================");
                Console.WriteLine("     Welcome to Oman Clinic Appointment System");
                Console.WriteLine("============================================");
                Console.WriteLine("1. Register New Patient");
                Console.WriteLine("2. Add New Doctor");
                Console.WriteLine("3. Search Doctor by Specialty");
                Console.WriteLine("4. Book Appointment");
                Console.WriteLine("5. View Patient Appointments");
                Console.WriteLine("6. View All Appointments");
                Console.WriteLine("7. Exit");
                Console.Write("Enter your choice: ");

                string choice = Console.ReadLine();
                Console.WriteLine("--------------------------------------------");

                switch (choice)
                {
                    case "1": RegisterPatient(); break;
                    case "2": AddDoctor(); break;
                    case "3": SearchDoctorBySpecialty(); break;
                    case "4": BookAppointment(); break;
                    case "5": ViewPatientAppointments(); break;
                    case "6": ViewAllAppointments(); break;
                    case "7":
                        Console.WriteLine("Thank you for using Oman Clinic Appointment System. Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }

        // 1. Register New Patient
        private void RegisterPatient()
        {
            Console.WriteLine("-- Register New Patient --");
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter National ID: ");
            string nationalId = Console.ReadLine();

            if (patients.Any(p => p.NationalID == nationalId))
            {
                Console.WriteLine("Patient with this National ID already exists!");
                return;
            }

            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();

            var patient = new Patient(patientCounter++, name, nationalId, phone);
            patients.Add(patient);
            Console.WriteLine("Patient registered successfully!");
        }

        // 2. Add New Doctor
        private void AddDoctor()
        {
            Console.WriteLine("-- Add New Doctor --");
            Console.Write("Enter Doctor Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Specialty: ");
            string specialty = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            string phone = Console.ReadLine();

            var doctor = new Doctor(doctorCounter++, name, specialty, phone);
            doctors.Add(doctor);
            Console.WriteLine("Doctor added successfully!");
        }

        // 3. Search Doctor by Specialty
        private void SearchDoctorBySpecialty()
        {
            Console.WriteLine("-- Search Doctor by Specialty --");
            Console.Write("Enter Specialty to search: ");
            string specialty = Console.ReadLine();

            var foundDoctors = doctors
                .Where(d => d.Specialty.Equals(specialty, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (foundDoctors.Count == 0)
            {
                Console.WriteLine("No doctors found for this specialty.");
                return;
            }

            Console.WriteLine("Doctors Found:");
            foreach (var doc in foundDoctors)
                Console.WriteLine($"- {doc.Name} | Phone: {doc.PhoneNumber}");
        }

        // 4. Book Appointment
        private void BookAppointment()
        {
            Console.WriteLine("-- Book Appointment --");
            Console.Write("Enter Patient National ID: ");
            string nationalId = Console.ReadLine();

            var patient = patients.FirstOrDefault(p => p.NationalID == nationalId);
            if (patient == null)
            {
                Console.WriteLine("Patient not found!");
                return;
            }

            Console.Write("Enter Doctor Name: ");
            string doctorName = Console.ReadLine();

            var doctor = doctors.FirstOrDefault(d =>
                d.Name.Equals(doctorName, StringComparison.OrdinalIgnoreCase));

            if (doctor == null)
            {
                Console.WriteLine("Doctor not found!");
                return;
            }

            Console.Write("Enter Appointment Date (dd/MM/yyyy): ");
            if (!DateOnly.TryParse(Console.ReadLine(), out DateOnly date))
            {
                Console.WriteLine("Invalid date format!");
                return;
            }

            bool doubleBooked = appointments.Any(a =>
                a.Doctor.DoctorID == doctor.DoctorID && a.Date == date);

            if (doubleBooked)
            {
                Console.WriteLine("Doctor already has an appointment on this date!");
                return;
            }

            var appointment = new Appointment(appointmentCounter++, patient, doctor, date);
            appointments.Add(appointment);
            Console.WriteLine("Appointment booked successfully!");
        }

        // 5. View Patient Appointments
        private void ViewPatientAppointments()
        {
            Console.WriteLine("-- View Patient Appointments --");
            Console.Write("Enter Patient National ID: ");
            string nationalId = Console.ReadLine();

            var patient = patients.FirstOrDefault(p => p.NationalID == nationalId);
            if (patient == null)
            {
                Console.WriteLine("Patient not found!");
                return;
            }

            var patientAppointments = appointments
                .Where(a => a.Patient.PatientID == patient.PatientID)
                .ToList();

            if (patientAppointments.Count == 0)
            {
                Console.WriteLine("No appointments found for this patient.");
                return;
            }

            Console.WriteLine($"Appointments for {patient.Name}:");
            foreach (var a in patientAppointments)
                Console.WriteLine($"- Date: {a.Date:dd/MM/yyyy} | Doctor: {a.Doctor.Name} | Specialty: {a.Doctor.Specialty}");
        }

        // 6. View All Appointments
        private void ViewAllAppointments()
        {
            Console.WriteLine("-- View All Appointments --");

            if (appointments.Count == 0)
            {
                Console.WriteLine("No appointments available.");
                return;
            }

            Console.WriteLine("All Booked Appointments:");
            int count = 1;
            foreach (var a in appointments)
            {
                Console.WriteLine($"{count++}. Patient: {a.Patient.Name} | Doctor: {a.Doctor.Name} | Date: {a.Date:dd/MM/yyyy} | Specialty: {a.Doctor.Specialty}");
            }
        }
    }

}

