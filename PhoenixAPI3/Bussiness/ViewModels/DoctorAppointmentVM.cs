using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Business.ViewModels
{
    public class DoctorAppointmentVM
    {
        public long Id { get; set; }
        public required string PatientName { get; set; }
        public required UserGender PatientGender { get; set; }
        public DateTime Start { get; set; }
    }
}
