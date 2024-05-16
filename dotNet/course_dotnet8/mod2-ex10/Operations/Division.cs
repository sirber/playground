namespace mod2_ex10.Operations;

public class Division : Operation
{
  public Division(int nb1, int nb2)
    : base(nb1, nb2)
  {
  }

  public override void Executer()
  {
    if (Nb2 == 0)
    {
      Resultat = 0;
      return;
    }

    Resultat = Nb1 / Nb2;
  }
}
