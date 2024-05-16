namespace mod2_ex7.Operations;

abstract public class Operation
{
  protected int Nb1;
  protected int Nb2;

  public int Resultat { get; set; }

  public Operation(int nb1, int nb2)
  {
    Nb1 = nb1;
    Nb2 = nb2;
  }

  abstract public void Executer();
}
