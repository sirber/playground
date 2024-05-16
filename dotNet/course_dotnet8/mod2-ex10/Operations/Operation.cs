namespace mod2_ex10.Operations;

abstract public class Operation : IOperation
{
  protected int Nb1 { get; }
  protected int Nb2 { get; }

  public int Resultat { get; protected set; }

  public Operation(int nb1, int nb2)
  {
    Nb1 = nb1;
    Nb2 = nb2;
  }

  abstract public void Executer();

  public override string ToString()
  {
    return $"{Nb1} + {Nb2} = {Resultat}";
  }
}
