using Microsoft.EntityFrameworkCore;
using TicketingCleanArchitecture.CoreLayer.Entities;

namespace TicketingCleanArchitecture.InfrastructureLayer.Data
{


    public class AppDbContext : DbContext
    {
        public IConfiguration _config { get; set; }
        public AppDbContext(IConfiguration config)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("DatabaseConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TicketAnswer>()
                .HasKey(ta => new { ta.TicketId, ta.AnswerId });

            modelBuilder.Entity<TicketAnswer>()
                .HasOne(ta => ta.Ticket)
                .WithMany(t => t.TicketAnswers)
                .HasForeignKey(ta => ta.TicketId);

            modelBuilder.Entity<TicketAnswer>()
                .HasOne(ta => ta.Answer)
                .WithMany(a => a.TicketAnswers)
                .HasForeignKey(ta => ta.AnswerId);
        }

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SupportTeamMember> SupportTeamMembers { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}