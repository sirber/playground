using System.Net;
using System.Net.Sockets;
using System.Text;
using server;

Console.WriteLine("Chat Server");

Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
IPEndPoint endPoint = new IPEndPoint(IPAddress.Any, 2345);
var clients = new List<Client>();

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

while (true)
{
  Socket clientSocket = socket.Accept();
  Thread clientThread = new(ListenClient)
  {
    IsBackground = true
  };
  clientThread.Start(clientSocket);
}

void ListenClient(object? clientSocket)
{
  if (clientSocket is Socket socket)
  {
    Client client = new(socket);
    clients.Add(client);

    Console.WriteLine("New client: " + client.Id);

    try
    {
      while (true)
      {
        // Get Message
        string message = client.Receive();
        Console.WriteLine($"[{client.Id}]: {message}");

        // Dispatch to other clients
        foreach (var c in clients)
        {
          if (c.Id == client.Id)
          {
            continue;
          }

          c.Send($"[{client.Id}] {message}");
        }
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine("Erreur de client: " + ex.Message);
    }
    finally
    {
      Console.WriteLine("Lost client: " + client.Id);

      if (socket.Connected)
      {
        socket.Shutdown(SocketShutdown.Both);
      }
      socket.Close();

      clients.Remove(client);
    }
  }
}