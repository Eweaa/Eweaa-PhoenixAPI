using PhoenixAPI3.Models;
using PhoenixAPI3.ViewModels;

namespace PhoenixAPI3.Bussiness.Interfaces;
public interface IAppointmentRepo
{
    ICollection<DoctorAppointmentVM> GetAllAppointmentsByDoctorId(int Id);
    ICollection<PatientAppointmentVM> GetAllAppointmentsByPatientId(int Id);
    bool CreateAppointment(Appointment appointment);
    bool UpdateAppointment(Appointment appointment);
    bool UpdateAppointmentStatus(int Id, AppointmentStatus statusType);
    bool AppointmentExists(int id);
    bool Save();
}