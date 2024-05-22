namespace mod6_ex1;

using System.Collections;

public class MaListeEnumerable : IEnumerator<int>
{
  private int[] Liste;

  private int Index = -1;

  private int Taille;

  public int Current => Liste[Index];

  object IEnumerator.Current => throw new NotImplementedException();

  public MaListeEnumerable(int taille)
  {
    Taille = taille;
    Liste = new int[taille];

    for (int i = 0; i < taille; i++)
    {
      Liste[i] = i + 1;
    }
  }

  public void Dispose()
  {
    // nothing
  }

  public bool MoveNext()
  {
    Index++;

    if (Index < Taille)
    {
      return true;
    }

    return false;
  }

  public void Reset()
  {
    Index = -1;
  }
}