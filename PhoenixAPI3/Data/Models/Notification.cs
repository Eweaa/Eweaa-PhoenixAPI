using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;

public class Notification : BaseEntity
{
    [ForeignKey("SendedUser")]
    public required long SendedBy { get; set; }
    public AppUser SendedUser { get; set; }


    [ForeignKey("ReceivedUser")]
    public required long ReceivedBy { get; set; }
    public AppUser ReceivedUser { get; set; }

    public NotificationType Type { get; set; }
    public NotificationPriority priority { get; set; }

    public NotificationStatus Status { get; set; }

}

public enum ChatMessageType
{
    Image = 1,
    Gif,
    Sticker,
    Emoje
}



public enum NotificationType
{
    Call,
    Video,
    NewComment,
    NewFeed,
}
public enum NotificationPriority
{
    low,
    medium,
    high,
}
public enum NotificationStatus
{
    fired = 1,
    seen,
}
