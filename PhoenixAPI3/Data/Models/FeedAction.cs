using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;

public class FeedAction : BaseEntity
{
    public required FeedActionType FeedActionType { get; set; }

    [ForeignKey("Feed")]
    public required long FeedId { get; set; }
    public Feed Feed { get; set; }

    [ForeignKey("CreatedUser")]
    public required long CreatedUserId { get; set; }
    public AppUser CreatedUser { get; set; }
}
