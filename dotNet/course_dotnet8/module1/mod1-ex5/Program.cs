Console.WriteLine("Votre nom?");
string? name = Console.ReadLine();

Console.WriteLine("Votre âge?");
int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Bonjour {name}, vous avez {age} ans.");