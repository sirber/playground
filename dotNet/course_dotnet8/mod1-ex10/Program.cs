const int NombreMystere = 7;

int essaie = -1;
while (essaie != NombreMystere)
{
  Console.Write("Devinez le nombre entre 1 et 10: ");
  essaie = Convert.ToInt32(Console.ReadLine());

  if (essaie > NombreMystere)
  {
    Console.WriteLine("Perdu! Le nombre est plus petit.");
  }
  else
  {
    Console.WriteLine("Perdu! Le nombre est plus grand.");
  }
}

Console.WriteLine("Bravo!");