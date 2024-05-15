using mod2_ex6;
using mod2_ex6.Operations;

Calculatrice calc = new();
Addidion add = new(6, 8);

calc.Executer(add);

Console.WriteLine(calc.Resultat);