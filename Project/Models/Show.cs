namespace Models
{
  public class Show
  {
    public int Id { get; set; }
    public string StartDateTime { get; set; } = "";

    public string EndDateTime { get; set; } = "";
    public int MovieId { get; set; }
    public int VenueId { get; set; }
  }
}