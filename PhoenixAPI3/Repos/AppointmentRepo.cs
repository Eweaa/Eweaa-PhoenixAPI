using Microsoft.EntityFrameworkCore;
using PhoenixAPI3.Data;
using PhoenixAPI3.Interfaces;
using PhoenixAPI3.Models;
using PhoenixAPI3.ViewModels;

namespace PhoenixAPI3.Repos;
public class AppointmentRepo : IAppointmentRepo
{
    private readonly DataContext _context;
    public AppointmentRepo(DataContext context)
    {
        _context = context;
    }
    public ICollection<DoctorAppointmentVM> GetAllAppointmentsByDoctorId(int Id) => _context.Appointments
        .Include(A => A.Patient)
        .Where(A => A.DoctorId == Id).Select(S => new DoctorAppointmentVM()
        {
            Id = S.Id,
            PatientName = S.Patient.Name,
            PatientGender = S.Patient.Gender,
            Start = S.Start
        }).ToList();

    public ICollection<PatientAppointmentVM> GetAllAppointmentsByPatientId(int Id) => _context.Appointments
        .Include(A => A.Doctor)
        .Where(A => A.PatientId == Id).Select(
                x => new PatientAppointmentVM()
                {
                    DoctorLocation = x.Doctor.Location,
                    DoctorName = x.Doctor.Name,
                    Id = x.Id,
                    Start = x.Start
                }
        ).ToList();

    public bool AppointmentExists(int id) => _context.Appointments.Any(A => A.Id == id);

    public bool CreateAppointment(Appointment appointment)
    {
        _context.Appointments.Add(appointment);
        return Save();
    }
    public bool Save()
    {
        var saved = _context.SaveChanges();
        return saved > 0 ? true : false;
    }
    public bool UpdateAppointment(Appointment appointment)
    {
        return Save();
    }
    public bool UpdateAppointmentStatus(int Id, AppointmentStatus statusType)
    {
        Appointment? appointment = _context.Appointments.Find(Id);
        if (appointment == null)
        {
            appointment!.Status = statusType;
            return Save();
        }
        else
        {
            return false;
        }
    }


}