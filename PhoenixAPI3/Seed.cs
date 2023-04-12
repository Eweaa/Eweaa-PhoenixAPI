﻿using PhoenixAPI3.Data;
using PhoenixAPI3.Models;

namespace PhoenixAPI3
{
    public class Seed
    {
        private readonly DataContext dataContext;
        public Seed(DataContext context)
        {
            this.dataContext = context;
        }
        public void SeedDataContext()
        {
            if (!dataContext.AppUsers.Any())
            {
                var patients = new List<AppUser>()
                {
                    new AppUser()
                    {
                        Name = "Ahmed",
                        Email = "Ahmed@yahoo.com",
                        Bio = "Lorem Ipsum",
                        Gender = UserGender.Male,
                        PhoneNumber = "0123456789",
                        Location = "cairo",
                        UserType = UserType.Patient,
                        Password ="Password",
                    },
                    new AppUser()
                    {
                        Name = "Mohamed",
                        Email = "Mohamed@yahoo.com",
                        Bio = "Lorem Ipsum",
                        Gender = UserGender.Male,
                        PhoneNumber = "0123456789",
                        Location = "cairo",
                        UserType = UserType.Patient,
                         Password ="Password",
                    },
                    new AppUser()
                    {
                        Name = "sara",
                        Email = "sara@yahoo.com",
                        Bio = "Lorem Ipsum",
                        Gender = UserGender.Female,
                        PhoneNumber = "0123456789",
                        Location = "cairo",
                        UserType = UserType.Patient,
                         Password ="Password",
                    },
                    new AppUser()
                    {
                        Name = "salma",
                        Email = "salma@yahoo.com",
                        Bio = "Lorem Ipsum",
                        Gender = UserGender.Female,
                        PhoneNumber = "0123456789",
                        Location = "Aswan",
                        UserType = UserType.Patient,
                         Password ="Password",
                    },
                      new AppUser()
                    {
                        Name = "Mohsen",
                        Bio = "Lorem Ipsum",
                        Gender = UserGender.Male,
                        PhoneNumber = "01233435345",
                        Location = "Alexandria",
                        Email = "Mohsen@69.com",
                        UserType = UserType.Patient,
                         Password ="Password",

                    },
                    new AppUser()
                    {
                        Name = "Farida",
                        Bio = "Lorem Ipsum",
                        Gender = UserGender.Female,
                        PhoneNumber = "01233435345",
                        Location = "Alexandria",
                        Email = "Mohsen@69.com",
                        UserType = UserType.Patient,
                         Password ="Password",

                    }

                };
                dataContext.AppUsers.AddRange(patients);
                dataContext.SaveChanges();
            }

            if (!dataContext.Appointments.Any())
            {
                var appointments = new List<Appointment>()
                {
                    new Appointment() {PatientId = 20, DoctorId = 23, Start = DateTime.Now.AddDays(1), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 21, DoctorId = 23, Start = DateTime.Now.AddDays(2).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 22, DoctorId = 23, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)},

                    new Appointment() {PatientId = 20, DoctorId = 23, Start = DateTime.Now.AddDays(2), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 21, DoctorId = 23, Start = DateTime.Now.AddDays(1).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 22, DoctorId = 23, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)},

                    new Appointment() {PatientId = 20, DoctorId = 24, Start = DateTime.Now.AddDays(2), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 21, DoctorId = 24, Start = DateTime.Now.AddDays(2).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 22, DoctorId = 24, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)},

                    new Appointment() {PatientId = 20, DoctorId = 24, Start = DateTime.Now.AddDays(2), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 21, DoctorId = 24, Start = DateTime.Now.AddDays(2).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 22, DoctorId = 24, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)},

                    new Appointment() {PatientId = 20, DoctorId = 25, Start = DateTime.Now.AddDays(2), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 21, DoctorId = 25, Start = DateTime.Now.AddDays(2).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 22, DoctorId = 25, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)},

                    new Appointment() {PatientId = 20, DoctorId = 24, Start = DateTime.Now.AddDays(2), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 21, DoctorId = 24, Start = DateTime.Now.AddDays(2).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 22, DoctorId = 24, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)},

                    new Appointment() {PatientId = 20, DoctorId = 23, Start = DateTime.Now.AddDays(2), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 21, DoctorId = 24, Start = DateTime.Now.AddDays(2).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 22, DoctorId = 25, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)},

                    new Appointment() {PatientId = 20, DoctorId = 23, Start = DateTime.Now.AddDays(2), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 21, DoctorId = 24, Start = DateTime.Now.AddDays(2).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 22, DoctorId = 25, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)}
                };
                dataContext.Appointments.AddRange(appointments);
                dataContext.SaveChanges();
            }
        }
    }
}
