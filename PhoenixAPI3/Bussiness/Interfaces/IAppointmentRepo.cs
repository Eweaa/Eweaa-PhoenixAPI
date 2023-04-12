using PhoenixAPI3.Business.ViewModels;
using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Business.Interfaces;
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