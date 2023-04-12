using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixAPI3.Data.Models;

public class Burn : BaseEntity
{
    [ForeignKey("Burned")]
    public required long BurnedId { get; set; }
    public AppUser Burned { get; set; }
    public required string ImagePath { get; set; }

}