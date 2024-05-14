using mod2_ex1;

int num1 = 6;
int num2 = 8;

Calculatrice calc = new();

Console.WriteLine(calc.Addition(num1, num2));
Console.WriteLine(calc.Soustraction(num1, num2));
Console.WriteLine(calc.Multiplication(num1, num2));
Console.WriteLine(calc.Division(num1, num2));
Console.WriteLine(calc.Modulo(num1, num2));