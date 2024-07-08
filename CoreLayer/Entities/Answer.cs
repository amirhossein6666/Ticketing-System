namespace TicketingSystem.Answer;

public class Answer
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    public DateTime SendDate { get; set; }

    public int TicketId { get; set; }
    public Ticket.Ticket Ticket { get; set; }

    public int SupportTeamMemberID { get; set; }
    public SupportTeamMember.SupportTeamMember SupportTeamMember { get; set; }
}