using PhoenixAPI3.Data;
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
            if (!dataContext.Patients.Any()) {
                var patients = new List<Patient>()
                {
                    new Patient()
                    {
                        Name = "Ahmed",
                        Email = "Ahmed@yahoo.com",
                        Bio = "Lorem Ipsum",
                        Gender = true,
                        PhoneNumber = "0123456789",
                        Location = "cairo",
                        Role = true,
                    },
                    new Patient()
                    {
                        Name = "Mohamed",
                        Email = "Mohamed@yahoo.com",
                        Bio = "Lorem Ipsum",
                        Gender = true,
                        PhoneNumber = "0123456789",
                        Location = "cairo",
                        Role = true
                    },
                    new Patient()
                    {
                        Name = "sara",
                        Email = "sara@yahoo.com",
                        Bio = "Lorem Ipsum",
                        Gender = false,
                        PhoneNumber = "0123456789",
                        Location = "cairo",
                        Role = true
                    },
                    new Patient()
                    {
                        Name = "salma",
                        Email = "salma@yahoo.com",
                        Bio = "Lorem Ipsum",
                        Gender = false,
                        PhoneNumber = "0123456789",
                        Location = "Aswan",
                        Role = true
                    }

                };
                dataContext.Patients.AddRange(patients);
            }
            //if (!dataContext.Doctors.Any()) {
            //    var doctors = new List<Doctor>()
            //    {
            //        new Doctor()
            //        {
            //            Name = "Mohsen",
            //            Bio = "Lorem Ipsum",
            //            Gender = true,
            //            PhoneNumber = "01233435345",
            //            Location = "Alexandria",
            //            Email = "Mohsen@69.com",
            //            Role = false,

            //        },
            //        new Doctor()
            //        {
            //            Name = "Farida",
            //            Bio = "Lorem Ipsum",
            //            Gender = false,
            //            PhoneNumber = "01233435345",
            //            Location = "Alexandria",
            //            Email = "Mohsen@69.com",
            //            Role = false,
            //        }
            //    };
            //    dataContext.Doctors.AddRange(doctors);
            //}
            if (!dataContext.Appointments.Any())
            {
                var appointments = new List<Appointment>()
                {
                    new Appointment() {PatientId = 13, DoctorId = 5, Start = DateTime.Now.AddDays(2), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 14, DoctorId = 5, Start = DateTime.Now.AddDays(2).AddMinutes(30), Duration = TimeSpan.FromMinutes(30)},
                    new Appointment() {PatientId = 15, DoctorId = 6, Start = DateTime.Now, Duration = TimeSpan.FromMinutes(30)},
                    //new Appointment() {PatientId = 16, DoctorId = 6, Start = DateTime.Now.AddMinutes(30), Duration = TimeSpan.FromMinutes(30)}
                };
                dataContext.Appointments.AddRange(appointments);
            }
            dataContext.SaveChanges();
        }
    }
}
