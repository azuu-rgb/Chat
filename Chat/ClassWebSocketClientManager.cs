using System;

public class WebSocketClientManager
{
    private WebSocketSharp.WebSocket cliente;

    public Action<string> AlRecibirMensaje; 

    public void Conectar(string url = "ws://192.168.33.183:8181")
    {
        cliente = new WebSocketSharp.WebSocket(url);

        cliente.OnMessage += (remitente, evento) =>
        {
           
            AlRecibirMensaje.Invoke(evento.Data);
        };

        cliente.Connect(); 
    }

    public void EnviarMensaje(string mensaje)
    {
        cliente.Send(mensaje); 
    }

    public void Cerrar()
    {
        cliente.Close(); 
    }
}

