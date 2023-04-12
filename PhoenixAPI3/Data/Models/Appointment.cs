using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models
{
    public class Appointment
    {
        public long Id { get; set; }
        public AppUser Doctor { get; set; }
        [ForeignKey("Doctor")]
        public long DoctorId { get; set; }
        public AppUser Patient { get; set; }
        [ForeignKey("Patient")]
        public long PatientId { get; set; }
        public DateTime Start { get; set; }
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
        Proccecing,
        Completed
    }
}
