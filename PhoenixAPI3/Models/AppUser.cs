namespace PhoenixAPI3.Models
{
    public class AppUser : Doctor
    {
        public UserType UserType { get; set; }
        public string Password { get; set; }
    }
    public enum UserType
    {
        Patient = 1 , Doctor
    }
}
