using mod2_ex10;
using mod2_ex10.Operations;

int nb1 = 0;
int nb2 = 0;
string operateur = "";

Console.Write("Entrez un deuxième chiffre: ");

IOperation operation;

while (true)
{
  Console.Write("Entrez un opérateur, ou 'q' pour quitter: ");
  operateur = Console.ReadLine();

  if (operateur == "q")
  {
    break;
  }

  Console.Write("Entrez un premier chiffre: ");
  nb1 = int.Parse(Console.ReadLine());

  Console.Write("Entrez un deuxième chiffre: ");
  nb2 = int.Parse(Console.ReadLine());

  switch (operateur)
  {
    case "+":
      operation = new Addition(nb1, nb2);
      break;

    // TODO: implémenter les autres

    default:
      Console.WriteLine("Opération non reconnue: " + operateur);
      return;
  }

  Calculatrice calc = new(operation);
  calc.Executer();
}

foreach (IOperation op in Historique.Operations)
{
  Console.WriteLine(op.ToString());
}