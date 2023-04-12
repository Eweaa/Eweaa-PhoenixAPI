//using Microsoft.EntityFrameworkCore;
//using PhoenixAPI3.Data;
//using PhoenixAPI3.Interfaces;
//using PhoenixAPI3.Models;

//namespace PhoenixAPI3.Repos
//{
//    public class DoctorRepo : IDoctor
//    {
//        private readonly DataContext _context;
//        public DoctorRepo(DataContext context)
//        {
//            _context = context;
//        }

//        public bool CreateDoctor(Doctor Doctor)
//        {
//            _context.Add(Doctor);
//            return Save();
//        }

//        public bool DoctorExists(int Id) => _context.Doctors.Any(D=> D.Id == Id);

//        public Doctor GetDoctor(int Id) => _context.Doctors.Where(D => D.Id == Id).Include(D => D.Appointments).FirstOrDefault();

//        public ICollection<Doctor> GetDoctors() => _context.Doctors.Include(D => D.Appointments).ToList();
//        public bool Save()
//        {
//            var saved = _context.SaveChanges();
//            return saved > 0 ? true : false;
//        }
//    }
//}
