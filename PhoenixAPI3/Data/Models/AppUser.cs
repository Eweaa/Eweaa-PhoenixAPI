namespace PhoenixAPI3.Data.Models;
public class AppUser : BaseEntity
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string? Location { get; set; }
    public UserGender Gender { get; set; }
    public string? Bio { get; set; }
    public UserType UserType { get; set; }
    public string? ImagePath { get; set; }
    public RateCount Rate { get; set; }
    public int FreeSession { get; set; } = 2;
    public virtual ICollection<Appointment>? DoctorAppointments { get; set; }
    public virtual ICollection<Appointment>? PatientAppointments { get; set; }
    public virtual ICollection<AppUser>? Followers { get; set; }
    public virtual ICollection<Notification>? SendNotifications { get; set; }
    public virtual ICollection<Notification>? ReceivedNotifications { get; set; }

    public virtual ICollection<ChatBox>? FirstInChatBox { get; set; }
    public virtual ICollection<ChatBox>? SecondInChatBox { get; set; }
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
public enum RateCount
{
    One = 1, Two, Three, Four, Five
}

