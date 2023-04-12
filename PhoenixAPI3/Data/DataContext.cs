using Microsoft.EntityFrameworkCore;
using PhoenixAPI3.Data.Models;

namespace PhoenixAPI3.Data;
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    public DbSet<Appointment> Appointments { get; set; }

    public DbSet<AppUser> AppUsers { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Burn> Burns { get; set; }
    public DbSet<Feed> Feeds { get; set; }
    public DbSet<FeedAction> FeedActions { get; set; }
    public DbSet<FeedComment> FeedComments { get; set; }
    public DbSet<Notification> Notifications { get; set; }

    public DbSet<ChatBox> ChatBoxs { get; set; }
    public DbSet<ChatBoxDetails> ChatBoxDetails { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppUser>()
        .HasMany(c => c.DoctorAppointments)
        .WithOne(e => e.Doctor)
        .OnDelete(DeleteBehavior.ClientSetNull);

        modelBuilder.Entity<AppUser>()
         .HasMany(c => c.PatientAppointments)
         .WithOne(e => e.Patient)
         .OnDelete(DeleteBehavior.ClientSetNull);


        modelBuilder.Entity<AppUser>()
        .HasMany(c => c.SendNotifications)
        .WithOne(e => e.SendedUser)
        .OnDelete(DeleteBehavior.ClientSetNull);

        modelBuilder.Entity<AppUser>()
         .HasMany(c => c.ReceivedNotifications)
         .WithOne(e => e.ReceivedUser)
         .OnDelete(DeleteBehavior.ClientSetNull);



        modelBuilder.Entity<AppUser>()
        .HasMany(c => c.FirstInChatBox)
        .WithOne(e => e.First)
        .OnDelete(DeleteBehavior.ClientSetNull);

        modelBuilder.Entity<AppUser>()
         .HasMany(c => c.SecondInChatBox)
         .WithOne(e => e.Second)
         .OnDelete(DeleteBehavior.ClientSetNull);


        modelBuilder.Entity<Feed>()
         .HasMany(c => c.Comments)
         .WithOne(e => e.Feed)
         .OnDelete(DeleteBehavior.ClientSetNull);

        modelBuilder.Entity<Feed>()
        .HasMany(c => c.Actions)
        .WithOne(e => e.Feed)
        .OnDelete(DeleteBehavior.ClientSetNull); 


        modelBuilder.Entity<ChatBox>()
       .HasMany(c => c.Details)
       .WithOne(e => e.ChatBox)
       .OnDelete(DeleteBehavior.ClientSetNull);

        base.OnModelCreating(modelBuilder);
    }
}
