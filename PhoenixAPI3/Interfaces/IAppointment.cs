using PhoenixAPI3.Models;
using PhoenixAPI3.ViewModels;

namespace PhoenixAPI3.Interfaces
{
    public interface IAppointment
    {
        ICollection<DoctorAppointmentVM> GetAllAppointmentsByDoctor(int Id);
        ICollection<Appointment> GetAllAppointmentsByPatient(int Id);
        bool AppointmentExists(int id);
        bool CreateAppointment(Appointment appointment);
        bool Save();
    }
}
