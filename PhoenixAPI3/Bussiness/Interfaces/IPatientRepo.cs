using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Business.Interfaces;
public interface IPatientRepo
{
    ICollection<AppUser> GetPatients();
    //ICollection<Doctor> GetDoctors();
    AppUser? GetPatient(int id);
    bool PatientExists(int id);
    bool CreatePatient(AppUser patient);
    bool Save();
}

