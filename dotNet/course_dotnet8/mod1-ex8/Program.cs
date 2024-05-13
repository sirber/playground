const int NbAnswers = 3;
string[] answers = new string[NbAnswers];

for (int i = 0; i < NbAnswers; i++)
{
  Console.Write($"Write something ({i + 1}/{NbAnswers}): ");
  answers[i] = Console.ReadLine() ?? "n/a";
}

for (int i = 0; i < NbAnswers; i++)
{
  Console.WriteLine($"Answer {i + 1}: {answers[i]}");
}