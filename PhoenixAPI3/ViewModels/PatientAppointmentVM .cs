using PhoenixAPI3.Models;

namespace PhoenixAPI3.ViewModels
{
    public class PatientAppointmentVM
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public UserGender Gender { get; set; }
        public DateTime Start { get; set; }
    }
}
