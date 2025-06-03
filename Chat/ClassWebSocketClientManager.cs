using System;

public class WebSocketClientManager
{
    private WebSocketSharp.WebSocket client;

    public Action<string> OnMessageReceived;

    public void Connect(string url = "ws://172.20.10.5:8181")
    {
        client = new WebSocketSharp.WebSocket(url);

        client.OnMessage += (sender, e) =>
        {
            OnMessageReceived?.Invoke(e.Data);
        };

        client.Connect();
    }

    public void SendMessage(string message)
    {
        client?.Send(message);
    }

    public void Close()
    {
        client?.Close();
    }
}

