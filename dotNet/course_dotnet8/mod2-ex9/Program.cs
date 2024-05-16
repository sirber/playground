using mod2_ex9;
using mod2_ex9.Operations;

Addition add = new(6, 8);
Calculatrice calc = new(add);

calc.Executer();

Console.WriteLine(calc.Resultat);