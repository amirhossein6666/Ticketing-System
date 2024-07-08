namespace TicketingCleanArchitecture.CoreLayer.Entities;

public enum Status
{
    Unread = 1,
    Pending = 2,
    Closed = 3,
    Cancelled = 4
}

public enum Rating
{
    OneStar = 1,
    TwoStar = 2,
    ThreeStar = 3,
    FourStar = 4,
    FiveStar = 5
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

    public ICollection<Answer> Answers { get; set; } = new List<Answer>();

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

    // public SupportTeamMemberCategory Category { get; set; }

    // public ICollection<SupportTeamMember.SupportTeamMember> Respondents { get; set; }

}