using PhoenixAPI3.Models;

namespace PhoenixAPI3.Bussiness.Interfaces;
public interface IDoctorRepo
{
    ICollection<AppUser> GetDoctors();
    AppUser? GetDoctor(int Id);
    bool DoctorExists(int Id);
    bool CreateDoctor(AppUser Doctor);
    bool Save();
}

