using Microsoft.EntityFrameworkCore;

namespace TicketingCleanArchitecture.CoreLayer.Entities
{
    [Index(nameof(UserName), IsUnique = true)]
    public class Customer
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string Name { get; set; }

        public ICollection<Ticket> Tickets { get; set; }
    }
}