using Microsoft.EntityFrameworkCore;
using PhoenixAPI3.Models;

namespace PhoenixAPI3.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        //public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
