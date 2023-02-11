using Microsoft.EntityFrameworkCore;

namespace NationalParkApi.Models
{
  public class NationalParkApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public NationalParkApiContext(DbContextOptions<NationalParkApiContext> options) : base(options) { }
  }
}