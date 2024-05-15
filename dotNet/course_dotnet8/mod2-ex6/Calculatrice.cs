using mod2_ex6.Operations;

namespace mod2_ex6;

public class Calculatrice
{
  public int Resultat => Operation.Resultat;
  public Operation Operation { get; }

  public Calculatrice(Operation operation)
  {
    Operation = operation;
  }

  public void Executer()
  {
    // Could be just Operation.Executer();

    if (Operation is Addidion add)
    {
      add.Executer();
    }
    else if (Operation is Soustraction sub)
    {
      sub.Executer();
    }
    else if (Operation is Division div)
    {
      div.Executer();
    }
    else if (Operation is Multiplication mul)
    {
      mul.Executer();
    }
    else if (Operation is Modulo mod)
    {
      mod.Executer();
    }
  }
}
