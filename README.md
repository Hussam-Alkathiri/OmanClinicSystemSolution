# 🏥 Oman Clinic Appointment System (C#)

A console-based application for managing patient registrations, doctor listings, and appointment bookings for a local clinic in Muscat.  
This system demonstrates key **Object-Oriented Programming (OOP)** concepts using C# such as **Encapsulation**, **Relationships**, and **Data Validation**.

---

## 📘 Table of Contents
- 🧍‍♂️ [Patient Management](#-patient-management)  
- 🩺 [Doctor Management](#-doctor-management)  
- 📅 [Appointment Booking](#-appointment-booking)  
- 🧠 [Concepts Covered](#-concepts-covered)  
- 🧑‍💻 [Author](#-author)

---

## 🧍‍♂️ Patient Management
**Concepts Used:** Encapsulation, Validation, List Management  

### Description:
Allows clinic staff to register new patients with unique **National IDs** and store their contact information.

### Features:
- Register new patients with:
  - `Name`
  - `National ID` (unique)
  - `Phone Number`
- Prevents duplicate National IDs.
- Stores patient data in an in-memory list.

---

## 🩺 Doctor Management
**Concepts Used:** Encapsulation, Collections, Object Relationships  

### Description:
Clinic staff can add new doctors, each with their own **specialty** and **contact details**.

### Features:
- Add new doctors with:
  - `Name`
  - `Specialty` (e.g., Pediatrics, Cardiology, Dermatology)
  - `Phone Number`
- Search doctors by specialty.
- Prevents duplicate entries.

---

## 📅 Appointment Booking
**Concepts Used:** Foreign Keys, Relationships (1-to-Many), Data Validation  

### Description:
Patients can book appointments with available doctors.  
The system ensures no doctor is double-booked on the same day.

### Features:
- Book appointment by entering:
  - `Patient National ID`
  - `Doctor Name`
  - `Appointment Date`
- Validates:
  - Patient and doctor exist.
  - Doctor is not already booked on that date.
- View:
  - All appointments.
  - Specific patient’s appointments.

---

## 🧠 Concepts Covered
✅ Encapsulation  
✅ Relationships (One-to-Many)  
✅ Foreign Key Usage (`[ForeignKey]` attribute)  
✅ Validation & Search (LINQ)  
✅ Console-Based Menu System  

---

## 🧑‍💻 Author
**Hussam Al Kathiri**  
📍 Salalah, Oman  
📧 [hussamalk10@gmail.com](mailto:hussamalk10@gmail.com)  
🔗 [LinkedIn](https://www.linkedin.com/in/hussam-alkathiri)
