using Microsoft.EntityFrameworkCore;

namespace TicketingCleanArchitecture.CoreLayer.Entities
{

    [Index(nameof(UserName), IsUnique = true)]
    public class SupportTeamMember
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string PassWord { get; set; }

        public string Name { get; set; }

        public ICollection<Answer> Answers { get; set; }
    }
}