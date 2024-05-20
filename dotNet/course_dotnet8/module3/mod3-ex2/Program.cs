// Part of Calculatrice

int GetIntValue(int nb)
{
  int? result = null;

  while (result is null)
  {
    Console.Write($"Saisissez la valeur {nb} entière: ");
    string? val = Console.ReadLine();

    if (val is not null)
    {
      try
      {
        result = int.Parse(val);
      }
      catch { }
    }
  }

  if (result.HasValue)
  {
    return result.Value;
  }

  return 0;
}

int o1 = GetIntValue(1);
int o2 = GetIntValue(2);
