public class Todo
{

  // HashSet<int> hs = new HashSet<int>();
  public static string Sample()
  {
    //this is how sets are implemented in c#
    HashSet<int> hs = new HashSet<int>();
    hs.Add(1);
    return "kala kela";
  }
  public int Id { get; set; }
  public string? Name { get; set; }
  public bool IsComplete { get; set; }
}
