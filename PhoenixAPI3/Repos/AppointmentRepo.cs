using Microsoft.EntityFrameworkCore;
using PhoenixAPI3.Data;
using PhoenixAPI3.Interfaces;
using PhoenixAPI3.Models;
using PhoenixAPI3.ViewModels;

namespace PhoenixAPI3.Repos
{
    public class AppointmentRepo : IAppointmentRepo
    {
        private readonly DataContext _context;
        public AppointmentRepo(DataContext context)
        {
            _context = context;
        }


        public ICollection<DoctorAppointmentVM> GetAllAppointmentsByDoctorId(int Id) => _context.Appointments
            .Include(A => A.Patient)
            .Where(A => A.DoctorId == Id).Select(S => new DoctorAppointmentVM()
            {
                Id = S.Id,
                Name = S.Patient.Name,
                Gender = S.Patient.Gender,
                Start = S.Start
            }).ToList();


        public ICollection<Appointment> GetAllAppointmentsByPatientId(int Id) => _context.Appointments
            .Include(A => A.Doctor)
            .Where(A => A.PatientId == Id).ToList();

        public bool AppointmentExists(int id) => _context.Appointments.Any(A => A.Id == id);

        public bool CreateAppointment(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }


    }
}
