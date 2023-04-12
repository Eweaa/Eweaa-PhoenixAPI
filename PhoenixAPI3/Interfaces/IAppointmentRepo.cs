using PhoenixAPI3.Models;
using PhoenixAPI3.ViewModels;

namespace PhoenixAPI3.Interfaces
{
    public interface IAppointmentRepo
    {
        ICollection<DoctorAppointmentVM> GetAllAppointmentsByDoctorId(int Id);
        ICollection<Appointment> GetAllAppointmentsByPatientId(int Id);
        bool AppointmentExists(int id);
        bool CreateAppointment(Appointment appointment);
        bool Save();
    }
}
