using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using BibliotecaDados;
using System.Net.Sockets;
using System.Net;

namespace Servidor
{
    public class Program
    {
        static void Main(string[] args)
        {
            //mensaje de servidor iniciado
            Console.WriteLine("Server iniciado");
            //se insntancia un hilo escuchador
            Thread hiloEscuchador = new Thread(IniciarServer);
            //se inicia el hilo
            hiloEscuchador.Start();

        }

        //se define el méotodo Iniciar Servidor
        public static void IniciarServer()
        {
            //se instancia un objeto de la clase TcpListener con una IP cualquiera y el puerto 9091
            TcpListener server = new TcpListener(IPAddress.Any, 9091);
            //se define una variable del tipo TcpClient
            TcpClient jugador;
            while (true)
            {
                //se inicia el objeto server
                server.Start();
                if (server.Pending())
                {//mientras el servidor tenga conexiones pendientes
                    //se define un jugador que llamará al método AcceptTcpClient
                    jugador = server.AcceptTcpClient();
                    //se instancia un nuevo cliente
                    Usuario cliente = new Usuario("");
                    //se instancia un objeto de la clase ComunicacionCliente
                    ComunicacionCliente com = new ComunicacionCliente(jugador, cliente);
                    //se llamada al método EnviarDatosCliente
                    com.EnviarDatosCliente(cliente.id.ToString());
                }
            }
        }
    }
}
