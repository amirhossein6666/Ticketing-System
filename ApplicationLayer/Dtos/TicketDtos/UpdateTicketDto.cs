using TicketingCleanArchitecture.CoreLayer.Enums;

namespace TicketingCleanArchitecture.ApplicationLayer.Dtos.TicketDtos;

public class UpdateTicketDto
{
    public string Title { get; set; }

    public string Message { get; set; }

    public TicketStatus Status { get; set; }

    public Rating Rating { get; set; }
}