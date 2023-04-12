namespace PhoenixAPI3.Business.ViewModels;
public class PatientAppointmentVM
{
    public long Id { get; set; }
    public required string DoctorName { get; set; }
    public required string DoctorLocation { get; set; }
    public DateTime Start { get; set; }
}