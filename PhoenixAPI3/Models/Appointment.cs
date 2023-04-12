namespace PhoenixAPI3.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public AppUser AppUser { get; set; }
        public int AppUserId { get; set; }
        public AppUser Doctor { get; set; }
        public int DoctorId { get; set; }
        public Patient Patient { get; set; }
        public int PatientId { get; set; }
        public DateTime Start { get; set; }
        public TimeSpan Duration { get; set; }
        public Appointment()
        {
            Duration = TimeSpan.FromMinutes(30);
        }
    }
}
