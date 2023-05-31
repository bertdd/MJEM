namespace MJEM;

internal abstract class Bread
{
  internal Bread(string description)
  {
    Description = description;
  }

  public override string ToString()
  {
    return $"{Description} kost {Price}";
  }

  internal decimal Price;

  internal string Description;
}
