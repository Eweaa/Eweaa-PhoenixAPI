using Microsoft.EntityFrameworkCore;
using PhoenixAPI3.Data;
using PhoenixAPI3.Interfaces;
using PhoenixAPI3.Models;

namespace PhoenixAPI3.Repos;
public class DoctorRepo : IDoctorRepo
{
    private readonly DataContext _context;
    public DoctorRepo(DataContext context)
    {
        _context = context;
    }

    public bool CreateDoctor(AppUser Doctor)
    {
        _context.Add(Doctor);
        return Save();
    }

    public bool DoctorExists(int Id) => _context.AppUsers.Any(D => D.Id == Id);

    public AppUser GetDoctor(int Id) => _context.AppUsers.Where(D => D.Id == Id).Include(D => D.DoctorAppointments).FirstOrDefault();

    public ICollection<AppUser> GetDoctors() => _context.AppUsers.Include(D => D.DoctorAppointments).ToList();
    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}

