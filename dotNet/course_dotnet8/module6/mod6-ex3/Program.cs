using mod6_ex3;

// Data
var personnes = new List<Personne>();

personnes.Add(new Personne()
{
  Nom = "Roger",
  Prenom = "Roger",
  DateNaissance = DateTime.Today,
  TailleCm = 120,
  Sexe = Sexe.Homme,
});

personnes.Add(new Personne()
{
  Nom = "Julie",
  Prenom = "Julie",
  DateNaissance = DateTime.Today,
  TailleCm = 100,
  Sexe = Sexe.Femme,
});

personnes.Add(new Personne()
{
  Nom = "Tom",
  Prenom = "Tom",
  TailleCm = 80,
  Sexe = Sexe.Homme,
});

// Select
List<string> noms = personnes.Select(p => p.Nom).ToList();
foreach (var nom in noms)
{
  Console.WriteLine("Nom: " + nom);
}

// Where
List<Personne> personnesAvecDateNaissance = personnes
  .Where(p => p.DateNaissance.HasValue).ToList();
Console.WriteLine("Personnes avec une date de naissance: " + personnesAvecDateNaissance.Count);