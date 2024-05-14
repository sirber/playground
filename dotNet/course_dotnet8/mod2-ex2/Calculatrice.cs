namespace mod2_ex2;

public class Calculatrice
{
  /// <summary>
  /// Additionne deux nombbres
  /// </summary>
  /// <param name="num1"></param>
  /// <param name="num2"></param>
  /// <returns>le résultat</returns>
  public int Addition(int num1, int num2)
  {
    return num1 + num2;
  }

  /// <summary>
  /// Soustait deux nombres
  /// </summary>
  /// <param name="num1"></param>
  /// <param name="num2"></param>
  /// <returns>le résultat</returns>
  public int Soustraction(int num1, int num2)
  {
    return num1 - num2;
  }

  /// <summary>
  /// Multiplie deux nombres
  /// </summary>
  /// <param name="num1"></param>
  /// <param name="num2"></param>
  /// <returns>le résultat</returns>
  public int Multiplication(int num1, int num2)
  {
    return num1 * num2;
  }

  /// <summary>
  /// Divise deux nombres
  /// </summary>
  /// <param name="num1"></param>
  /// <param name="num2"></param>
  /// <returns>le résultat</returns>
  public int Division(int num1, int num2)
  {
    if (num2 == 0)
    {
      return 0;
    }

    return num1 / num2;
  }

  /// <summary>
  /// Modulo deux nombres
  /// </summary>
  /// <param name="num1"></param>
  /// <param name="num2"></param>
  /// <returns>le résultat</returns>
  public int Modulo(int num1, int num2)
  {
    return num1 % num2;
  }
}
