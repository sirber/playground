Console.WriteLine("Votre nom?");
string? name = Console.ReadLine();

Console.WriteLine("Votre âge?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Bonjour {name}, vous avez {age} ans.");

bool isMineur = age <= 18;
if (isMineur)
{
  Console.WriteLine("Vous êtes mineur.");
}
else
{
  Console.WriteLine("Vous êtes majeur.");
}