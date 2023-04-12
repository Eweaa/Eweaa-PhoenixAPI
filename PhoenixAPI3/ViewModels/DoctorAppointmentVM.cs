using PhoenixAPI3.Models;

namespace PhoenixAPI3.ViewModels
{
    public class DoctorAppointmentVM
    {
        public long Id { get; set; }
        public required string PatientName { get; set; }
        public required UserGender PatientGender { get; set; }
        public DateTime Start { get; set; }
    }
}
