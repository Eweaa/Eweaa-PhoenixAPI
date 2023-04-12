using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;


public class Appointment : BaseEntity
{
    [ForeignKey("Doctor")]
    public long DoctorId { get; set; }
    public AppUser Doctor { get; set; }

    [ForeignKey("Patient")]
    public long PatientId { get; set; }
    public AppUser Patient { get; set; }

    public DateTime StartedAt { get; set; }
    public TimeSpan Duration { get; set; }
    public AppointmentStatus Status { get; set; }

    public Appointment()
    {
        Duration = TimeSpan.FromMinutes(30);
    }
}


public enum AppointmentStatus
{
    Initiated = 1,
    Pending,
    Processing,
    Completed
}


