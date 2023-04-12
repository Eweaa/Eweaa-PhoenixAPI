using System.ComponentModel.DataAnnotations.Schema;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace PhoenixAPI3.Data.Models
{
    public class AppUser
    {

        public long Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Location { get; set; }
        public UserGender Gender { get; set; }
        public string Bio { get; set; }
        public UserType UserType { get; set; }

        public virtual ICollection<Appointment>? DoctorAppointments { get; set; }
        public virtual ICollection<Appointment>? PatientAppointments { get; set; }
    }

    public enum UserType
    {
        Patient = 1,
        Doctor
    }
    public enum UserGender
    {
        Male = 1,
        Female
    }
}
