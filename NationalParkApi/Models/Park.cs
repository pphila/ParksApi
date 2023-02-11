using System.ComponentModel.DataAnnotations;

namespace NationalParkApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    [Required]
    [StringLength(25)]
    public string Name { get; set; }
    [Required]
    [StringLength(20)]
    public string State { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    [StringLength(20)]
    public string DateEst { get; set; }
  }
}