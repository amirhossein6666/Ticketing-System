namespace TicketingCleanArchitecture.CoreLayer.Entities;

public enum Status
{
    Unread,
    Pending,
    Closed,
    Cancelled

}

public enum Rating
{
    OneSta=1,
    TwoStar,
    ThreeStar,
    FourStar,
    FiveStar
}

// public enum SupportTeamMemberCategory
// {
//     TechnicalTeam,
//     SalesTeam,
//     OfficeTeam
// }
public class Ticket
{
    public int Id { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    public DateTime SendDate { get; set; }

    public Status Status { get; set; }

    public Rating Rating { get; set; }

    public ICollection<Answer> Answers { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    // public SupportTeamMemberCategory Category { get; set; }

    // public ICollection<SupportTeamMember.SupportTeamMember> Respondents { get; set; }

}