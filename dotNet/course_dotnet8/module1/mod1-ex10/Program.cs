const int NombreMystere = 7;
int essaie = -1; // could be bool gagne = false
List<int> nbJoue = new List<int>();

while (essaie != NombreMystere)
{
  Console.Clear();

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
  essaie = Convert.ToInt32(Console.ReadLine());

  nbJoue.Add(essaie);
}

Console.WriteLine("Bravo!");