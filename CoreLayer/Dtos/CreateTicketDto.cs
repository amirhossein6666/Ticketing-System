using TicketingCleanArchitecture.CoreLayer.Enums;

namespace TicketingCleanArchitecture.CoreLayer.Dtos;

public class CreateTicketDto
{
    public string Title { get; set; }

    public string Message { get; set; }

    public DateTime SendDate { get; set; }

    public TicketStatus Status { get; set; }

    public TicketRating Rating { get; set; }

    public int CustomerId { get; set; }

}