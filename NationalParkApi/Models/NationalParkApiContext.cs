using Microsoft.EntityFrameworkCore;

namespace NationalParkApi.Models
{
  public class NationalParkApiContext : DbContext
  {
    public DbSet<Park> Parks { get; set; }

    public NationalParkApiContext(DbContextOptions<NationalParkApiContext> options) : base(options) { }
  
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
        .HasData(
          new Park { ParkId = 1, Name = "Yellowstone", State = "Wyoming", Description = "Expansive park with large networks of geothermal areas including boiling mud pots, vividly colored hot springs such as Grand Prismatic Spring, geysers, yellow hued grand canyon of the Yellowstone river, mountians, and bounties of wildlife.", DateEst = "March 1, 1872"},
          new Park { ParkId = 2, Name = "Sequoia", State = "California", Description = "Home to the giant Sequoia forest, known for being the largest trees found in the world.", DateEst = "September 25, 1890"},
          new Park { ParkId = 3, Name = "Yosemite", State = "California", Description = "Known for giant shear granit cliffs and exceptionally tall water falls, old growth forests, Noteable landmarks include: El Capitan, Half Dome, and the glacier carved Yosemite Valley", DateEst = "October 1, 1890"},
          new Park { ParkId = 4, Name = "Mount Rainer", State = "Washington", Description = "Home to an active stratovolcano of the parks namesake. This park is also home to the contigous states longest and largest glacier. Popular for climbing, backpacking, hiking in its subalpine and alpine forests.", DateEst = "March 2, 1899"},
          new Park { ParkId = 5, Name = "Crater Lake", State = "Oregon", Description = "Crater Lake lies in a caldera of an ancient volcano called Mount Mazama that collapsed 7,700 years ago. The lake is the deepest in the United States and is noted for its vivid blue water color and water clarity.", DateEst = "May 22, 1902"}
        );
    }
  }
}