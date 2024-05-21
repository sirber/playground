using mod3_ex8;

Console.WriteLine("Launching an exception...");

try
{
  throw new MonException();
}
catch (MonException e)
when (e.Message is not null)
{
  Console.WriteLine("MonException catched with message!");
  Console.WriteLine(e.Message);
}
catch (MonException)
{
  Console.WriteLine("MonException catched!");
}
catch
{
  Console.WriteLine("Exception catched!");
}
finally
{
  Console.WriteLine("Finally!");
}
