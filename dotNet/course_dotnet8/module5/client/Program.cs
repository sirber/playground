using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("Chat Client");

Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
IPEndPoint endPoint = new IPEndPoint(IPAddress.Loopback, 2345);

try
{
  // Connecting
  socket.Connect(endPoint);

  // Sending
  string? message = null;
  while (true)
  {
    Console.Write("Message (q pour quitter):");
    message = Console.ReadLine();

    if (message is null || message == "q")
    {
      break;
    }

    Console.WriteLine("Sending: " + message);
    socket.Send(Encoding.UTF8.GetBytes(message));
  }
}
catch (Exception ex)
{
  Console.WriteLine("Client error: " + ex.Message);
}
finally
{
  if (socket.Connected)
  {
    socket.Close();
  }
}