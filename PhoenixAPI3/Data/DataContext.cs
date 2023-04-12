using Microsoft.EntityFrameworkCore;
using PhoenixAPI3.Models;

namespace PhoenixAPI3.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppUser>()
            .HasMany(c => c.DoctorAppointments)
            .WithOne(e => e.Doctor)
            .OnDelete(DeleteBehavior.ClientSetNull);

        modelBuilder.Entity<AppUser>()
         .HasMany(c => c.PatientAppointments)
         .WithOne(e => e.Patient).OnDelete(DeleteBehavior.ClientSetNull);
        base.OnModelCreating(modelBuilder);
    }
}
