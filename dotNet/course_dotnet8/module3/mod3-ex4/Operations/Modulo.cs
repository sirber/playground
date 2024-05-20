namespace mod2_ex10.Operations;

public class Modulo : Operation
{
  public Modulo(int nb1, int nb2)
    : base(nb1, nb2)
  {
  }

  public override void Executer()
  {
    Resultat = Nb1 % Nb2;
  }

  public override string ToString()
  {
    return $"{Nb1} % {Nb2}";
  }

  public override bool Equals(object? obj)
  {
    if (obj is Modulo m)
    {
      return Nb1 == m.Nb1 && Nb2 == m.Nb2;
    }

    return false;
  }
}
