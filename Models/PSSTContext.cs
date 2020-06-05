using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PSST.Models
{
  public class PSSTContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<Flavor> Flavors { get; set; }
    public virtual DbSet<Treat> Treats { get; set; }
    public virtual DbSet<FlavorTreat> FlavorTreat { get; set; }

    public PSSTContext(DbContextOptions options) : base(options) { }
  }
}