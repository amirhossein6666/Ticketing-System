using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketingCleanArchitecture.CoreLayer.Entities;

public class Answer
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    public DateTime SendDate { get; set; }

    public ICollection<Ticket> Replies { get; set; }
    public ICollection<TicketAnswer> TicketAnswers { get; set; }

    public int SupportTeamMemberID { get; set; }
    public SupportTeamMember SupportTeamMember { get; set; }
}