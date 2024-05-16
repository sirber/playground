namespace mod2_ex9.Operations;

abstract public class Operation : IOperation
{
  protected int Nb1 { get; }
  protected int Nb2 { get; }

  public int Resultat { get; set; }

  public Operation(int nb1, int nb2)
  {
    Nb1 = nb1;
    Nb2 = nb2;
  }

  abstract public void Executer();
}
