using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;

public class ChatBoxDetails : BaseEntity
{
    [ForeignKey("ChatBox")]
    public required long ChatBoxId { get; set; }
    public ChatBox ChatBox { get; set; }

    [ForeignKey("Sender")]
    public required long SenderId { get; set; }
    public AppUser Sender { get; set; }

    public string Content { get; set; }

    public required ChatMessageType FeedActionType { get; set; }
}
