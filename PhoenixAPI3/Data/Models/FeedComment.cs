using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;

public class FeedComment : BaseEntity
{
    public required FeedCommentType FeedActionType { get; set; }
    public required string Content { get; set; }

    [ForeignKey("Feed")]
    public required long FeedId { get; set; }
    public required Feed Feed { get; set; }


    [ForeignKey("CreatedUser")]
    public required long CreatedBy { get; set; }
    public required AppUser CreatedUser { get; set; }
}
