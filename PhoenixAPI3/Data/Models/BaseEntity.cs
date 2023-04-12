using System.ComponentModel.DataAnnotations;

namespace PhoenixAPI3.Data.Models;
public class BaseEntity
{
    [Required]
    public long Id { get; set; }
    [Required]
    public DateTime CreatedDate { get; set; }
}