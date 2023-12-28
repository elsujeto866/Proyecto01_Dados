using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDados;
using System.IO;
using System.Threading;

namespace Servidor
{
    public class ComunicacionCliente
    {

        //se define una lista de clientes
        static List<string> clientes = new List<string>();
        //se define el lector de la clase StreamReader
        StreamReader lector;
        //se define el escritor de la claseStreamWriter
        StreamWriter escritor;
        //se define un jugador de la clase TcpClient
        TcpClient jugador;
        string[] datos = null;
        //se define un cliente de la clase Cliente
        Usuario cliente = new Usuario("");

        //definimos las propiedades de los atributos
        public string[] Datos { get => datos; set => datos = value; }
        

        //constructor con parámetros de entrada: TcoClient y Cliente
        public ComunicacionCliente(TcpClient jugador, Usuario cliente)
        {
            this.jugador = jugador;
            this.cliente = cliente;
            //se define un hilo Validador que llame al método ValidarUsuario
            Thread hiloValidador = new Thread(ValidarUsuario);
            //se inicia el hilo
            hiloValidador.Start();

        }

        //método para validar que el usuario no exista
        public void ValidarUsuario()
        {
            //lector de la clase StreamReader
            lector = new StreamReader(jugador.GetStream());
            //escritor de la clase StreamWriter
            escritor = new StreamWriter(jugador.GetStream());
            escritor.WriteLine("Hola, para poder iniciar escribe un nombre de usuario!!");
            escritor.Flush();
            cliente.nombre = ObtenerUsuario();
            //se define el while mientras en la lista de clientes se contenga el nombre del cliente
            while (clientes.Contains(cliente.nombre))
            {
                //se envía mensaje que el usuario ya existe
                escritor.WriteLine("/n" + ":" + " Ese nombre de usuario ya existe =(");
                escritor.Flush();
                cliente.nombre = ObtenerUsuario();
            }
            //string donde va el id y nombre del cliente
            string validacion = "/t" + ":" + cliente.id + ":" + cliente.nombre;
            //se imprime el string
            escritor.WriteLine(validacion);
            //se hace el envío del dato
            escritor.Flush();
            //string para señalar el cliente que se ha conectado
            string RESP_DADO = "El usuario " + cliente.nombre + " se ha conectado (ID: " + cliente.id + ")";
            //se imprime el mensaje
            Console.WriteLine(RESP_DADO);
            //se añade el cliente
            clientes.Add(cliente.nombre);
            //se instancia un hilo comunicador
            Thread hiloComunicador = new Thread(RecibirDatosCliente);
            //se inicia el hilo
            hiloComunicador.Start();
        }
        //método para obtener el usuario
        private string ObtenerUsuario()
        {
            return lector.ReadLine();
        }

        //método para recibir datos del cliente
        public void RecibirDatosCliente()
        {
            //se instancia un lector
            lector = new StreamReader(jugador.GetStream());

            while (true)
            {
                string RESP_DADO = lector.ReadLine();
                datos = RESP_DADO.Split(':');
                if (cliente.Obtenerpuntaje()!=null )
                {


                    string resp = "Servidor REINCIADO!! " + cliente.Obtenerpuntaje() + " " + cliente.ObtenerNombre();                            ;
                    //mensaje de servidor reiniciado
                    EnviarDatosCliente(RESP_DADO);
                    Console.WriteLine("El usuario " + cliente.nombre + " de ID " + cliente.id + " ha reiniciado el servidor");
                }
                else if (datos[0] == "/c")
                {
                    //se imprime mensaje del usuario desconectado
                    Console.WriteLine("El usuario de ID: " + cliente.id + " y Nombre: " + cliente.nombre +
                        " se ha desconectado del servidor");
                    //se elimina el cliente de la lista
                    clientes.Remove(this.cliente.nombre);
                }
                else
                {
                   
                }

            }
        }

        //se define método enviar datos al cliente
        public void EnviarDatosCliente(string datos)
        {
            //se instancia un objeto de la clase StreamWriter
            escritor = new StreamWriter(jugador.GetStream());
            //se escriben los datos
            escritor.WriteLine(datos);
            escritor.Flush();
        }

        //método para calcular el puntaje y realizar el conteo de dados
                
    }
}
