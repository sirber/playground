using System.Net;
using System.Net.Sockets;
using System.Text;

Console.WriteLine("Chat Server");

Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 2345);

try
{
  // Listen
  socket.Bind(endPoint);
  socket.Listen();
}
catch
{
  Console.WriteLine("Could not listen.");
  Environment.Exit(1);
}

try
{
  // New connection from client
  Socket client = socket.Accept();
  Console.WriteLine("Connection réussie");

  if (client.RemoteEndPoint is not null)
  {
    Console.WriteLine("Connection de: " + client.RemoteEndPoint.ToString());

    // Get data
    while (true)
    {
      byte[] buffer = new byte[128];
      int nbBytes = client.Receive(buffer);
      
      if (nbBytes == 0) {
        break;
      }

      string message = Encoding.UTF8.GetString(buffer, 0, nbBytes);
      Console.WriteLine("Reçu: " + message);
    }
  }
}
catch (Exception ex)
{
  Console.WriteLine("Erreur de serveur: " + ex.Message);
}
finally
{
  if (socket.Connected)
  {
    socket.Shutdown(SocketShutdown.Both);
  }
  socket.Close();
}