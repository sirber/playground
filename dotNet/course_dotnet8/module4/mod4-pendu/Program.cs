using mod4_pendu;

string mot = "souris";
string? lettre;
bool found = false;

Pendu pendu = new(mot);

while (true)
{
  Console.Clear();

  pendu.AfficherEssais();
  pendu.AfficherMot();
  Console.WriteLine();
  pendu.AfficherPendu();

  if (pendu.MotTrouve())
  {
    found = true;
    break;
  }

  if (pendu.EstPendu())
  {
    break;
  }

  Console.Write("Entrer une lettre: ");
  lettre = Console.ReadLine();
  if (string.IsNullOrEmpty(lettre))
  {
    continue;
  }

  pendu.NouvelEssai(lettre[0]);
}

if (found)
{
  Console.WriteLine("Bravo! le mon était: " + mot);
}
else
{
  Console.WriteLine("Vous êtes mort!");
}