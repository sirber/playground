using mod2_ex8;
using mod2_ex8.Operations;

Addition add = new(6, 8);
Calculatrice calc = new(add);

calc.Executer();

Console.WriteLine(calc.Resultat);