using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TicketingCleanArchitecture.CoreLayer.Enums;

namespace TicketingCleanArchitecture.CoreLayer.Entities;

public class Ticket
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string Title { get; set; }

    public string Message { get; set; }

    public DateTime SendDate { get; set; }

    public TicketStatus Status { get; set; }

    public Rating? Rating { get; set; }

    public ICollection<Answer> Answers { get; set; }
    public ICollection<TicketAnswer> TicketAnswers { get; set; }

    public int CustomerId { get; set; }
    public Customer Customer { get; set; }

}