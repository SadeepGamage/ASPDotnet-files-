using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EventManagementSystem.Models;
namespace EventManagementSystem.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=EventManagementSystem.db");
        }
        public DbSet<EventModel>Event { set; get; }
        public DbSet<RegistrationModel>Registration { get; set; }
        public DbSet<TicketModel> Ticket { get; set; }
        public DbSet<UserModel> User { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        base.OnModelCreating(modelBuilder);

        // Configure the primary key for each entity
        modelBuilder.Entity<EventModel>()
            .HasKey(e => e.EventId);

        modelBuilder.Entity<RegistrationModel>()
            .HasKey(r => r.RegistrationId);

        modelBuilder.Entity<TicketModel>()
            .HasKey(t => t.TicketId);

        modelBuilder.Entity<UserModel>()
            .HasKey(u => u.UserId);

        // Configure relationships

        // One-to-Many relationship between Event and Registrations
        modelBuilder.Entity<RegistrationModel>()
            .HasOne(r => r.Event)
            .WithMany(e => e.Registrations)
            .HasForeignKey(r => r.EventId);

        // One-to-Many relationship between Event and Tickets
        modelBuilder.Entity<TicketModel>()
            .HasOne(t => t.Event)
            .WithMany(e => e.Tickets)
            .HasForeignKey(t => t.EventId);

        // One-to-Many relationship between User and Registrations
        modelBuilder.Entity<RegistrationModel>()
            .HasOne(r => r.User)
            .WithMany(u => u.Registrations)
            .HasForeignKey(r => r.UserId);

        // One-to-Many relationship between User and Tickets
        modelBuilder.Entity<TicketModel>()
            .HasOne(t => t.User)
            .WithMany(u => u.Tickets)
            .HasForeignKey(t => t.UserId);

        // Additional configurations can be added here if needed
        }
    }
}