namespace mod6_ex2;

public static class IntExtensions
{
  public static int ComparePair(this int[] data)
  {
    int nbEven = 0;

    foreach (var item in data)
    {
      if (item % 2 == 0)
      {
        nbEven++;
      }
    }

    return nbEven;
  }
}
