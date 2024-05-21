using mod3_ex7;

Console.WriteLine("Launching an exception...");

try
{
  throw new MonException();
}
catch
{
  Console.WriteLine("Exception catched!");
}
