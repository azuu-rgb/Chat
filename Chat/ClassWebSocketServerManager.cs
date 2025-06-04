using Fleck;
using System;
using System.Collections.Generic;

public class WebSocketServerManager
{
    private WebSocketServer servidor;
    private List<IWebSocketConnection> sockets;

    public Action<string> OnMessageReceived;

    public void IniciarServidor(string address = "ws://0.0.0.0:8181")
    {
        sockets = new List<IWebSocketConnection>();
        servidor = new WebSocketServer(address);

        servidor.Start(socket =>
        {
            socket.OnOpen = () =>
            {
                Console.WriteLine("Cliente conectado!");
                sockets.Add(socket);
            };

            socket.OnClose = () =>
            {
                Console.WriteLine("Cliente desconectado.");
                sockets.Remove(socket);
            };

            socket.OnMessage = message =>
            {
                Console.WriteLine("Mensaje recibido del cliente: " + message);
                OnMessageReceived?.Invoke(message); 
            };
        });

        Console.WriteLine("Servidor WebSocket iniciado en " + address);
    }

    public void EnviarMensaje(string message)
    {
        foreach (var socket in sockets)
        {
            socket.Send(message);
        }
    }
}
