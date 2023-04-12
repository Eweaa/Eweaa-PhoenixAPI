using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;

public class ChatBox : BaseEntity
{
    [ForeignKey("First")]
    public required long FirstId { get; set; }
    public AppUser First { get; set; }


    [ForeignKey("Second")]
    public required long SecondId { get; set; }
    public AppUser Second { get; set; }

    public ICollection<ChatBoxDetails>? Details { get; set; }
}
