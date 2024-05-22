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

  // Receive (async)
  var receiveEventArgs = new SocketAsyncEventArgs();
  receiveEventArgs.SetBuffer(new byte[1024], 0, 1024);
  receiveEventArgs.Completed += OnReceiveCompleted;
  socket.ReceiveAsync(receiveEventArgs);

  // Sending
  string? message = null;
  while (true)
  {
    message = Console.ReadLine();

    if (message is null || message == "q")
    {
      break;
    }

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

void OnReceiveCompleted(object? sender, SocketAsyncEventArgs e)
{
  int bytesRead = e.BytesTransferred;
  if (bytesRead == 0 || e.Buffer is null)
  {
    throw new Exception("No Data");
  }

  string receivedText = Encoding.UTF8.GetString(e.Buffer, e.Offset, bytesRead);

  Console.WriteLine(receivedText);
}