using TicketingCleanArchitecture.CoreLayer.Enums;

namespace TicketingCleanArchitecture.ApplicationLayer.Dtos.TicketDtos;

public class CreateTicketDto
{
    public string Title { get; set; }

    public string Message { get; set; }

    public DateTime SendDate { get; set; }

    public TicketStatus Status { get; set; }

    public Rating Rating { get; set; }

    public int CustomerId { get; set; }

}