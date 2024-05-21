using System.Runtime.Serialization;

namespace mod3_ex7;

public class MonException : Exception
{
  public MonException()
  {
  }

  public MonException(string? message) : base(message)
  {
  }

  public MonException(string? message, Exception? innerException) : base(message, innerException)
  {
  }

  protected MonException(SerializationInfo info, StreamingContext context) : base(info, context)
  {
  }
}
