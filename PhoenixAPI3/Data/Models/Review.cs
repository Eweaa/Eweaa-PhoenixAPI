using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;
public class Review : BaseEntity
{

    [ForeignKey("Reviewer")]
    public required long ReviewerId { get; set; }
    public AppUser Reviewer { get; set; }

    public required string Content { get; set; }
    public required RateCount RateCount { get; set; }
}
