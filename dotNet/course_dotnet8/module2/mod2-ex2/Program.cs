using mod2_ex2;

Calculatrice calc = new();
int nb1 = 0;
int nb2 = 0;
int retour = 0;
string operateur = "";

while (nb1 <= 0)
{
  try
  {
    Console.Write("Veuillez entrer un premier chiffre: ");
    nb1 = int.Parse(Console.ReadLine() ?? "0");
  }
  catch
  {
    Console.WriteLine("Chiffre non valide.");
  }
}

while (nb2 <= 0)
{
  try
  {
    Console.Write("Veuillez entrer un deuxième chiffre: ");
    nb2 = int.Parse(Console.ReadLine() ?? "0");
  }
  catch
  {
    Console.WriteLine("Chiffre non valide.");
  }
}

Console.Write("Veuillez entrer un opérateur: ");
operateur = Console.ReadLine() ?? "";

switch (operateur)
{
  case "+":
    retour = calc.Addition(nb1, nb2);
    break;

  case "-":
    retour = calc.Soustraction(nb1, nb2);
    break;

  case "/":
    retour = calc.Division(nb1, nb2);
    break;

  case "*":
    retour = calc.Multiplication(nb1, nb2);
    break;

  case "%":
    retour = calc.Modulo(nb1, nb2);
    break;
}

Console.WriteLine($"Résultat: {retour}");