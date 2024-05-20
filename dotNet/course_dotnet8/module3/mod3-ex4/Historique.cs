using mod2_ex10.Operations;

namespace mod2_ex10;

public static class Historique
{
  public static List<IOperation> Operations { get; } = [];

  public static void Ajouter(IOperation operation)
  {
    Operations.Add(operation);
  }
}
