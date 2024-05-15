using mod2_ex6;
using mod2_ex6.Operations;

Addidion add = new(6, 8);
Calculatrice calc = new(add);

calc.Executer();

Console.WriteLine(calc.Resultat);