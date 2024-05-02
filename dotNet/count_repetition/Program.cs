using NUnit.Framework;

public class CountRepetition
{
  public int GetCountRepetition(int[] source)
  {
    int count = 0;
    var map = new Dictionary<int, int>();

    foreach (int number in source)
    {
      if (map.ContainsKey(number))
      {
        int value = map.GetValueOrDefault(number);
        map[number] = value + 1;
      }
      else
      {
        map.Add(number, 0);
      }
    }

    foreach (KeyValuePair<int, int> pair in map)
    {
      count += pair.Value;
    }

    return count;
  }
}

[TestFixture]
public class CountRepetitionTests
{
  [Test]
  public void GetCountRepetition_Test1()
  {
    // Arrange
    var repetition = new CountRepetition();
    var test = new int[] { 1, 2, 2, 3, 3, 3 };

    // Act
    int result = repetition.GetCountRepetition(test);

    // Assert
    Assert.That(result, Is.EqualTo(3));
  }

  [Test]
  public void GetCountRepetition_Test2()
  {
    // Arrange
    var repetition = new CountRepetition();
    var test = new int[] { 1, 1, 2, 2, 3, 3 };

    // Act
    int result = repetition.GetCountRepetition(test);

    // Assert
    Assert.That(result, Is.EqualTo(3));
  }

  [Test]
  public void GetCountRepetition_Test3()
  {
    // Arrange
    var repetition = new CountRepetition();
    var test = new int[] { 1, 2, 1, 2, 1, 2 };

    // Act
    int result = repetition.GetCountRepetition(test);

    // Assert
    Assert.That(result, Is.EqualTo(4));
  }
}