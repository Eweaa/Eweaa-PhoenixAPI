using PhoenixAPI3.Models;

namespace PhoenixAPI3.Interfaces
{
    public interface IPatientRepo
    {
        ICollection<AppUser> GetPatients();
        //ICollection<Doctor> GetDoctors();
        AppUser GetPatient(int id);
        bool PatientExists(int id);
        bool CreatePatient(AppUser patient);
        bool Save();
    }
}
