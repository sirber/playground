namespace mod2_ex10.Operations;

public class Soustraction : Operation
{
  public Soustraction(int nb1, int nb2)
    : base(nb1, nb2)
  {
  }

  public override void Executer()
  {
    Resultat = Nb1 - Nb2;
  }

  public override string ToString()
  {
    return $"{Nb1} - {Nb2}";
  }

  public override bool Equals(object? obj)
  {
    if (obj is Soustraction s)
    {
      return Nb1 == s.Nb1 && Nb2 == s.Nb2;
    }

    return false;
  }
}
