const int NombreMystere = 7;
int essaie = -1; // could be bool gagne = false
bool erreurSaisie = false;
List<int> nbJoue = new List<int>();

while (essaie != NombreMystere)
{
  Console.Clear();

  if (erreurSaisie)
  {
    Console.WriteLine("Erreur de saisie, essayer de nouveau.");
  }

  if (nbJoue.Count > 0)
  {
    Console.Write("Vous avez déjà essayé: ");
    foreach (int i in nbJoue)
    {
      Console.Write($"{i} ");
    }

    Console.WriteLine();
  }

  Console.Write("Devinez le nombre entre 1 et 10: ");

  try
  {
    erreurSaisie = false;
    essaie = Convert.ToInt32(Console.ReadLine());
    nbJoue.Add(essaie);
  }
  catch
  {
    erreurSaisie = true;
  }
}

Console.WriteLine("Bravo!");