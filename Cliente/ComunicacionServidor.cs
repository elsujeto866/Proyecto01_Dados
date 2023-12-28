using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_ErickO_DorianM
{
    public class ComunicacionServidor
    {
        TcpClient remoto; //Cliente TCP
        StreamReader lector; //Objeto para leer datos de un flujo
        StreamWriter escritor; //Objeto para escribir datos en un flujo
        //Variables que guardan la información que se recibe del servidor
        string DADO;
        string[] datos;

        /* Constructor de la clase. Realiza la conexión con el servidor utilizando el método Connect
         * e inicia el hilo (hilo comunicador) que recibe constantemente datos del servidor */
        public ComunicacionServidor(IPEndPoint ip)
        {
            remoto = new TcpClient();
            remoto.Connect(ip);
            Thread hiloComunicador = new Thread(RecibirDatosServidor);
            hiloComunicador.Start();
        }

        //Propiedades
        public string Msg { get => DADO; set => DADO = value; }
        public string[] Datos { get => datos; set => datos = value; }

        /* Método que envía datos del cliente al servidor */
        public void EnviarDatosServidor(string datos)
        {
            escritor = new StreamWriter(remoto.GetStream()); //Inicializamos el escritor de datos
            escritor.WriteLine(datos); //Escribimos en el flujo
            escritor.Flush(); //Enviamos los datos
        }

        /* Método que recibe datos desde el servidor */
        public void RecibirDatosServidor()
        {
            lector = new StreamReader(remoto.GetStream()); //Inicializamos el lector de datos
            //Lazo infinito ejecutado por el hilo comunicador
            while (true)
            {
                //Información recibida del servidor
                DADO = lector.ReadLine();
                Datos = DADO.Split(':');
            }
        }
    }
}
