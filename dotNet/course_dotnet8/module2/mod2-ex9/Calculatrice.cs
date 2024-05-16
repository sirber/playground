namespace mod2_ex9;

using mod2_ex9.Operations;

public class Calculatrice
{
  public int Resultat => Operation.Resultat;
  private IOperation Operation { get; }

  public Calculatrice(IOperation operation)
  {
    Operation = operation;
  }

  public void Executer()
  {
    Operation.Executer();
  }
}
