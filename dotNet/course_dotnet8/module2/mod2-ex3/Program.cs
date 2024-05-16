using mod2_ex3;

Calculatrice calc = new()
{
  OperandeGauche = 6,
  OperandeDroite = 8,
};

calc.Addition();

Console.WriteLine(calc.Resultat);