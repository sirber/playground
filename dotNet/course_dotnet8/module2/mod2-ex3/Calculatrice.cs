namespace mod2_ex3;

public class Calculatrice
{
  public int OperandeGauche { get; set; }
  public int OperandeDroite { get; set; }
  public int Resultat { get; set; }

  public void Addition()
  {
    Resultat = OperandeGauche + OperandeDroite;
  }

  public void Soustraction()
  {
    Resultat = OperandeGauche - OperandeDroite;
  }

  public void Multiplication()
  {
    Resultat = OperandeGauche * OperandeDroite;
  }

  public void Division()
  {
    if (OperandeDroite == 0)
    {
      Resultat = 0;
      return;
    }

    Resultat = OperandeGauche / OperandeDroite;
  }

  public void Modulo()
  {
    Resultat = OperandeGauche % OperandeDroite;
  }
}
