const int NombreMystere = 7;

Console.Write("Devinez le nombre entre 1 et 10: ");
int essaie = Convert.ToInt32(Console.ReadLine());

if (essaie == NombreMystere)
{
  Console.WriteLine("Bravo!");
}
else if (essaie > NombreMystere)
{
  Console.WriteLine("Perdu! Le nombre est plus petit.");
}
else
{
  Console.WriteLine("Perdu! Le nombre est plus grand.");
}