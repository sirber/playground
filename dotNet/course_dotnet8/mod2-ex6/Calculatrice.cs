using mod2_ex6.Operations;

namespace mod2_ex6;

public class Calculatrice
{
  public int Resultat { get; set; }

  public Calculatrice()
  {
    Resultat = 0;
  }

  public void Executer(Operation operation)
  {
    if (operation is Addidion add)
    {
      add.Executer();
    }
    else if (operation is Soustraction sub)
    {
      sub.Executer();
    }
    else if (operation is Division div)
    {
      div.Executer();
    }
    else if (operation is Multiplication mul)
    {
      mul.Executer();
    }
    else if (operation is Modulo mod)
    {
      mod.Executer();
    }

    Resultat = operation.Resultat;
  }
}
