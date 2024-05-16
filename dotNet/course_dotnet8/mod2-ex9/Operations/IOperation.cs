namespace mod2_ex9;

public interface IOperation
{
  int Nb1 { get; }
  int Nb2 { get; }
  int Resultat { get; set; }

  void Executer();
}
