namespace mod2_ex6.Operations;

public class Soustraction : Operation
{
  public Soustraction(int nb1, int nb2)
    : base(nb1, nb2)
  {
  }

  public void Executer()
  {
    Resultat = Nb1 - Nb2;
  }
}
