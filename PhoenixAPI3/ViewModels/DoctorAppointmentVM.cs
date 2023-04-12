using PhoenixAPI3.Models;

namespace PhoenixAPI3.ViewModels
{
    public class DoctorAppointmentVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public UserGender Gender { get; set; }
        public DateTime Start { get; set; }
    }
}
