using mod2_ex6;
using mod2_ex6.Operations;

Addition add = new(6, 8);
Calculatrice calc = new(add);

calc.Executer();

Console.WriteLine(calc.Resultat);