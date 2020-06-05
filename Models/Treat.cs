using System.Collections.Generic;

namespace PSST.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<FlavorTreat>();
    }

    public int TreatId { get; set; }

    [StringLength(255)]
    public string Name { get; set; }

    [StringLength(255)]
    public string Description { get; set; }

    public virtual ICollection<FlavorTreat> Flavors { get; set; }
    public virtual ApplicationUser User { get; set; }
  }
}