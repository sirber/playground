﻿namespace mod2_ex9.Operations;

public class Multiplication : Operation
{
  public Multiplication(int nb1, int nb2)
    : base(nb1, nb2)
  {
  }

  public override void Executer()
  {
    Resultat = Nb1 * Nb2;
  }
}
