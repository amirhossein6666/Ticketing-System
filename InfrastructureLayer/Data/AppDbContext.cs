using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace TicketingSystem
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

        public DbSet<Ticket.Ticket> Tickets { get; set; }
        public DbSet<Customer.Customer> Customers { get; set; }
        public DbSet<SupportTeamMember.SupportTeamMember> SupportTeamMembers { get; set; }
        public DbSet<Answer.Answer> Answers { get; set; }
    }
}