using Type = TicketingCleanArchitecture.CoreLayer.Enums.Type;

namespace TicketingCleanArchitecture.CoreLayer.Entities;

public class TicketAnswer
{
    public int TicketId { get; set; }
    public Ticket Ticket { get; set; }

    public int AnswerId { get; set; }
    public Answer Answer { get; set; }

    public Type Type { get; set; }
}