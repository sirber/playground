Console.Write("Allô! Dites quelques chose: ");
string? val = Console.ReadLine();
if (val is not null && val != "")
{
  Console.WriteLine("Vous avez écrit: " + val);
}
else
{
  Console.WriteLine("Rien n'a été écrit.");
}