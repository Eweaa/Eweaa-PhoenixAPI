using PhoenixAPI3.Models;

namespace PhoenixAPI3.Interfaces
{
    public interface IDoctor
    {
        ICollection<Doctor> GetDoctors();
        Doctor GetDoctor(int Id);
        bool DoctorExists(int Id);
        bool CreateDoctor(Doctor Doctor);
        bool Save();
    }
}
