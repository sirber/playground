using mod2_ex7;
using mod2_ex7.Operations;

Addidion add = new(6, 8);
Calculatrice calc = new(add);

calc.Executer();

Console.WriteLine(calc.Resultat);