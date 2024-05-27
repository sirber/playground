using System.Xml;
using mod7_ex1;

Personne personne = new();

var reader = XmlReader.Create("./fichier.xml");

reader.ReadStartElement("Personne");
{
  reader.ReadStartElement("Nom");
  personne.Nom = reader.ReadContentAsString();
  reader.ReadEndElement();

  reader.ReadStartElement("Prenom");
  personne.Prenom = reader.ReadContentAsString();
  reader.ReadEndElement();

  reader.ReadStartElement("DateDeNaissance");
  personne.DateDeNaissance = reader.ReadContentAsDateTime();
  reader.ReadEndElement();

  reader.ReadStartElement("Taille");
  personne.Taille = reader.ReadContentAsInt();
  reader.ReadEndElement();
}
reader.ReadEndElement();

reader.Close();

// Display
Console.WriteLine($"{personne.Prenom} {personne.Nom}");
Console.WriteLine($"Naissance: {personne.DateDeNaissance}");
Console.WriteLine($"Taille: {personne.Taille} cm");