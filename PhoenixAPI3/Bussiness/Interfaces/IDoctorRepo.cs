using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Business.Interfaces;
public interface IDoctorRepo
{
    ICollection<AppUser> GetDoctors();
    AppUser? GetDoctor(int Id);
    bool DoctorExists(int Id);
    bool CreateDoctor(AppUser Doctor);
    bool Save();
}

