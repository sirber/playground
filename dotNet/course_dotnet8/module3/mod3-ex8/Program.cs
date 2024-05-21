using mod3_ex8;

Console.WriteLine("Launching an exception...");

try
{
  throw new MonException();
}
catch (MonException)
{
  Console.WriteLine(" MonException catched!");
}
catch
{
  Console.WriteLine(" Exception catched!");
}
