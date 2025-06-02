using Fleck;
using System;
using System.Collections.Generic;

public class WebSocketServerManager
{
    private WebSocketServer server;
    private List<IWebSocketConnection> allSockets;

    public Action<string> OnMessageReceived;

    public void StartServer(string address = "ws://0.0.0.0:8181")
    {
        allSockets = new List<IWebSocketConnection>();
        server = new WebSocketServer(address);

        server.Start(socket =>
        {
            socket.OnOpen = () =>
            {
                Console.WriteLine("Cliente conectado!");
                allSockets.Add(socket);
            };

            socket.OnClose = () =>
            {
                Console.WriteLine("Cliente desconectado.");
                allSockets.Remove(socket);
            };

            socket.OnMessage = message =>
            {
                Console.WriteLine("Mensaje recibido del cliente: " + message);
                OnMessageReceived?.Invoke(message); // Llama al formulario
            };
        });

        Console.WriteLine("Servidor WebSocket iniciado en " + address);
    }

    public void SendMessageToAll(string message)
    {
        foreach (var socket in allSockets)
        {
            socket.Send(message);
        }
    }
}
