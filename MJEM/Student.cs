
namespace MJEM;

internal class Student
{
  internal Student(string name)
  {
    Name = name;
  }

  public string Name
  {
    get; set;
  }

  public bool HasCard
  {
    get; set;
  }

  public int Points
  {
    get; set;
  }

}
