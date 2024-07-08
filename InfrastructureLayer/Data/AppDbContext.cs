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

        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SupportTeamMember> SupportTeamMembers { get; set; }
        public DbSet<Answer> Answers { get; set; }
    }
}