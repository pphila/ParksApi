using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;


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
    [RegularExpression("^(state|national)$", ErrorMessage = "Type must be either 'state' or 'national'.")]
    public string Type { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    [StringLength(20)]
    public string DateEst { get; set; }
  }
}