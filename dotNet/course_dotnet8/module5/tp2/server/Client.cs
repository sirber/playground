using System.Net.Sockets;
using System.Text;

namespace server;

public class Client
{
  private Socket Socket;
  public string Id { get; private set; }

  public Client(Socket socket)
  {
    Socket = socket;
    Id = Guid.NewGuid().ToString();
  }

  public string Receive()
  {
    byte[] buffer = new byte[128];
    int nbBytes = Socket.Receive(buffer);

    if (nbBytes == 0)
    {
      throw new Exception("No Data");
    }

    string message = Encoding.UTF8.GetString(buffer, 0, nbBytes);

    return message;
  }

  public void Send(string message)
  {
    Socket.Send(Encoding.UTF8.GetBytes(message));
  }
}
