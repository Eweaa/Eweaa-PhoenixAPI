using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;


public class Feed : BaseEntity
{
    [ForeignKey("CreatedUser")]
    public long CreatedBy { get; set; }
    public required AppUser CreatedUser { get; set; }

    public ICollection<FeedComment>? Comments { get; set; }
    public ICollection<FeedAction>? Actions { get; set; }

}
public enum FeedActionType
{
    Like = 1,
    Heart,
    Smile,
}

public enum FeedCommentType
{
    Image = 1,
    Gif,
    Sticker,
    Emoji
}