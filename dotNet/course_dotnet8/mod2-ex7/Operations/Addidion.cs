﻿namespace mod2_ex7.Operations;

public class Addidion : Operation
{
  public Addidion(int nb1, int nb2)
    : base(nb1, nb2)
  {
  }

  public override void Executer()
  {
    Resultat = Nb1 + Nb2;
  }
}
