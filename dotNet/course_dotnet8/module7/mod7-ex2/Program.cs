using System.Xml;
using mod7_ex2;

var personne = new Personne()
{
  Nom = "Roger",
  Prenom = "Luc",
  DateDeNaissance = DateTime.Now,
  Taille = 120,
};

using (var writer = XmlWriter.Create("./output.xml"))
{
  writer.WriteStartElement("Personne");
  {
    writer.WriteElementString("Nom", personne.Nom);
    writer.WriteElementString("Prenom", personne.Prenom);
    writer.WriteElementString("DateDeNaissance", personne.DateDeNaissance.ToString());
    writer.WriteElementString("Taille", personne.Taille.ToString());
  }
  writer.WriteEndElement();
}