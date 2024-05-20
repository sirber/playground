using mod2_ex10;
using mod2_ex10.Operations;

int nb1 = 0;
int nb2 = 0;
string? operateur = "";

IOperation operation;

int GetIntValue(int nb)
{
  int? result = null;

  while (result is null)
  {
    Console.Write($"Saisissez la valeur {nb} entière: ");
    string? val = Console.ReadLine();

    if (val is not null)
    {
      try
      {
        result = int.Parse(val);
      }
      catch { }
    }
  }

  if (result.HasValue)
  {
    return result.Value;
  }

  return 0;
}

while (true)
{
  Console.Write("Entrez un opérateur, ou 'q' pour quitter: ");
  operateur = Console.ReadLine();

  if (operateur is null || operateur == "q")
  {
    break;
  }

  nb1 = GetIntValue(1);
  nb2 = GetIntValue(2);

  switch (operateur)
  {
    case "+":
      operation = new Addition(nb1, nb2);
      break;

    case "-":
      operation = new Soustraction(nb1, nb2);
      break;

    case "*":
      operation = new Multiplication(nb1, nb2);
      break;

    case "/":
      operation = new Division(nb1, nb2);
      break;

    case "%":
      operation = new Modulo(nb1, nb2);
      break;

    default:
      Console.WriteLine("Opération non reconnue: " + operateur);
      return;
  }

  Calculatrice calc = new(operation);
  calc.Executer();
}

foreach (IOperation op in Historique.Operations)
{
  Console.WriteLine(op.ToString() + " = " + op.Resultat);
}