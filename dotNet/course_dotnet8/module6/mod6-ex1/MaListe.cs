using System.Collections;

namespace mod6_ex1;

public class MaListe : IEnumerable<int>
{
  MaListeEnumerable Liste;

  public MaListe(int taille)
  {
    Liste = new(taille);
  }

  public IEnumerator<int> GetEnumerator()
  {
    return Liste;
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    return Liste;
  }
}
