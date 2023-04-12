using Microsoft.EntityFrameworkCore;
using PhoenixAPI3.Business.Interfaces;
using PhoenixAPI3.Data;
using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Business.Repos;
public class PatientRepo : IPatientRepo
{
    private readonly DataContext _context;
    public PatientRepo(DataContext context)
    {
        _context = context;
    }
    public ICollection<AppUser> GetPatients() => _context.AppUsers.Include(P => P.PatientAppointments).ToList();

    public bool PatientExists(int id) => _context.AppUsers.Any(p => p.Id == id);

    public AppUser? GetPatient(int id) => _context.AppUsers.Where(P => P.Id == id).Include(P => P.PatientAppointments).FirstOrDefault();
    public bool CreatePatient(AppUser patient)
    {
        _context.AppUsers.Add(patient);
        return Save();
    }
    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
}