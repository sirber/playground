namespace mod4_pendu;

public class Pendu
{
  private int NbEssai { get; set; }
  private int NbEssaiMax { get; set; }
  private string Mot { get; set; }
  private List<char> Essais;

  public Pendu(string mot)
  {
    NbEssaiMax = 7;
    Essais = new List<char>();

    Mot = mot;
    NbEssai = 0;
  }

  public void NouvelEssai(char lettre)
  {
    if (Essais.Contains(lettre))
    {
      return;
    }

    if (Mot.Contains(lettre) == false)
    {
      NbEssai++;
    }

    Essais.Add(lettre);
  }

  public void AfficherEssais()
  {
    Console.WriteLine("Essais: " + String.Join(" ", Essais));
  }

  public void AfficherMot()
  {
    Console.Write("Mot: ");

    foreach (char lettre in Mot.ToCharArray())
    {
      if (Essais.Contains(lettre))
      {
        Console.Write(lettre + " ");
      }
      else
      {
        Console.Write("_ ");
      }
    }

    Console.WriteLine();
  }

  public bool MotTrouve()
  {
    foreach (char lettre in Mot.ToCharArray())
    {
      if (Essais.Contains(lettre) == false)
      {
        return false;
      }
    }

    return true;
  }

  public bool EstPendu()
  {
    return NbEssai == NbEssaiMax;
  }

  public void AfficherPendu()
  {
    var template = "  --------------     " + Environment.NewLine +
        "    |        1       " + Environment.NewLine +
        "    |        1       " + Environment.NewLine +
        "    |       2 2'      " + Environment.NewLine +
        "    |       2'2¤2      " + Environment.NewLine +
        "    |      44355     " + Environment.NewLine +
        "    |        3       " + Environment.NewLine +
        "    |        3       " + Environment.NewLine +
        "    |       6 7      " + Environment.NewLine +
      @"   /|\     6   7     " + Environment.NewLine +
      @"  / | \              " + Environment.NewLine +
      @" /  |  \             ";

    for (int i = 1; i <= NbEssaiMax; i++)
    {
      if (NbEssai >= i)
      {
        if (i != 2)
        {
          template = template.Replace(i.ToString(), i switch
          {
            1 => "|",
            3 => "|",
            4 => "-",
            5 => "-",
            6 => "/",
            7 => "\\",
            _ => ""
          });
        }
        else
        {
          template = template
              .Replace("2'", "\\")
              .Replace("2¤", "_")
              .Replace("2", "/");
        }
      }
      else
      {
        template = template.Replace(i.ToString(), i switch
        {
          4 => " ",
          _ => ""
        })
        .Replace("'", "").Replace("¤", "");
      }

    }
    Console.Write(template);
    Console.WriteLine();
  }
}
