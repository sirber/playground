namespace mod2_ex4;

public class Calculatrice
{
  public int OperandeGauche { get; }
  public int OperandeDroite { get; }
  public int Resultat { get; set; }

  public Calculatrice(int operandeGauche = 1, int operandeDroite = 1)
  {
    OperandeGauche = operandeGauche;
    OperandeDroite = operandeDroite;
    Resultat = 0;
  }

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
