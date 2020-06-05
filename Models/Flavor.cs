using System.Collections.Generic;

namespace PSST.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<FlavorTreat>();
    }
    public int FlavorId { get; set; }

    [StringLength(255)]
    public string Name { get; set; }
    
    [StringLength(255)]
    public string Description { get; set; }

    public virtual ApplicationUser User { get; set; }
    public ICollection<FlavorTreat> Treats { get; }
  }
}