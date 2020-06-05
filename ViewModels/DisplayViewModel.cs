using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PSST.Models
{
  public class Display
  {
    public Flavor Flavor { get; set; }
    public Treat Treat { get; set; }
    public FlavorTreat FlavorTreat { get; set; }
  }
}