using Microsoft.EntityFrameworkCore;
using PhoenixAPI3.Data;
using PhoenixAPI3.Interfaces;
using PhoenixAPI3.Models;

namespace PhoenixAPI3.Repos
{
    public class PatientRepo : IPatient
    {
        private readonly DataContext _context;
        public PatientRepo(DataContext context)
        {
            _context = context;
        }
        public ICollection<Patient> GetPatients() => _context.Patients.Include(P => P.Appointments).ToList();

        //public ICollection<Doctor> GetDoctors() => _context.Doctors.ToList();

        public bool PatientExists(int id) => _context.Patients.Any(p => p.Id == id);

        public Patient GetPatient(int id) => _context.Patients.Where(P => P.Id == id).Include(P => P.Appointments).FirstOrDefault();
        public bool CreatePatient(Patient patient)
        {
            _context.Patients.Add(patient);
            return Save();
        }
        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }
    }
}
