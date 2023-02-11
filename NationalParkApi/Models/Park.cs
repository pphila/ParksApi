namespace NationalParkApi.Models
{
  public class Park
  {
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string State { get; set; }
    public string Description { get; set; }
    public string DateEst { get; set; }
  }
}