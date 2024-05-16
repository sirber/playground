namespace mod2_ex10;

using mod2_ex10.Operations;

public class Calculatrice
{
  public int Resultat => Operation.Resultat;
  private IOperation Operation { get; }

  public Calculatrice(IOperation operation)
  {
    Historique.Ajouter(operation);
    Operation = operation;
  }

  public void Executer()
  {
    Operation.Executer();
  }
}
