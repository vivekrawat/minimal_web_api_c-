namespace Models
{
  class Venue
  {
    private int _id;
    public int Id
    {
      get => _id;
      set
      {
        if (value < 0) throw new ArgumentException("ID cannot be negative");
        _id = value;
      }
    }
    public string Name { get; set; } = "";
    public string Address { get; set; } = "";
    public string Country { get; set; } = "";
  }
}