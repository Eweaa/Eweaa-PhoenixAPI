using PhoenixAPI3.Models;

namespace PhoenixAPI3.Interfaces
{
    public interface IPatient
    {
        ICollection<Patient> GetPatients();
        //ICollection<Doctor> GetDoctors();
        Patient GetPatient(int id);
        bool PatientExists(int id);
        bool CreatePatient(Patient patient);
        bool Save();
    }
}
