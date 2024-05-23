namespace mod6_ex3;

public enum Sexe
{
  Homme,
  Femme
}

public class Personne
{
  public required string Nom { get; set; }
  public required string Prenom { get; set; }
  public DateTime? DateNaissance { get; set; }
  public int TailleCm { get; set; }
  public Sexe Sexe { get; set; }
}
