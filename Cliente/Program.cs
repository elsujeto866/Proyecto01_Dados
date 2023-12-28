using System.Net;
using BibliotecaDados;
using System;
using System.Collections.Generic;
using System.Threading;
using Proyecto1_ErickO_DorianM;
internal class Program
{
    //Variables globales
    static string id = ""; //ID del cliente
    static string nombre = ""; //Nombre del cliente
    static Dado dado; //Objeto de tipo dado
    static int puntaje = 0;
    static Dado d;

    //Arreglos que permiten mostrar el menú para el cliente


    static void Main(string[] args)
    {
        //Creamos un IPEndPoint (127.0.0.1 y 9091) para inicializar el objeto ComunicacionServidor 
        IPEndPoint ip = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9091);
        
        ComunicacionServidor com = new ComunicacionServidor(ip);

        /* Etapa de ingreso del nombre de usuario del cliente */
        Thread.Sleep(100); //Detenemos el hilo principal durante 0.1s
        Console.WriteLine(com.Msg); //Se imprime la información enviada del servidor
        string val = Console.ReadLine(); //Nombre de usuario a ser validado
        com.EnviarDatosServidor(val); //Se envía al servidor el nombre de usuario


        Thread.Sleep(100); //Detenemos el hilo principal durante 0.1s

        /* Si la información obtenida del servidor empieza con un "/t" significa que el nombre de 
         * usuario fue aceptado. Si la información empieza con un "/n" significa que el nombre de
         * usuario se repite y no fue aceptado */
        if (com.Datos[0] == "/t")
        {
            //Si el nombre fue aceptado
            nombre = com.Datos[2]; //Se guarda el nombre del usuario
                                   //Se imprime un mensaje de bienvenida
            Console.WriteLine("Hola " + nombre + ", bienvenido al juego de dados!!");
            id = com.Datos[1]; //Se guarda el ID del usuario
            Console.WriteLine("Tu ID de cliente es: " + id); //Se imprime el ID del usuario
            EnviarDado(com); //Llamamos a la función Enviar

        }
        else if (com.Datos[0] == "/n")
        {
            //Si el nombre no fue aceptado (si se repite)
            while (com.Datos[0] == "/n")
            {
                Console.WriteLine(com.Datos[1]); //Se imprime el mensaje de error enviado por el servidor
                                                 //Se lee un nombre de usuario y se lo envía nuevamente para ser validado
                val = Console.ReadLine();
                com.EnviarDatosServidor(val);
                Thread.Sleep(100); //Detenemos el hilo por 0.1s
            }
        }
        //Una vez que se ha ingresado un nombre de usuario no repetido
        nombre = com.Datos[2]; //Se guarda el nombre del usuario
                               //Se imprime un mensaje de bienvenida
        Console.WriteLine("Hola " + nombre + ", bienvenido al juego de dados  Game.co!!");
        id = com.Datos[1]; //Se guarda el ID del usuario
        Console.WriteLine("Tu ID de cliente es: " + id); //Se imprime el ID del usuario
        EnviarDado(com); //LLamamos a la función EnviarCarta()

    }

    
    /* Función que muestra el menú que permimte escoger la carta la carta que se va a enviar al 
     * servidor para que este realice la cuenta */
    public static void EnviarDado(ComunicacionServidor com)
    {
        do
        {
            //Menú para escoger la familia de la carta
            Console.WriteLine("Escoja el dado");
            Console.WriteLine("\na) " +Dados_Enum.normal + "\n" +
            "b) " + Dados_Enum.octaedro + "\n" +
            "c) " + Dados_Enum.decaedro + "\n" +
            "d) " + Dados_Enum.dodecaedro + "\n" +
            "e) Reiniciar servidor");
            char opc = Char.Parse(Console.ReadLine());
            
            switch (opc)
            {
                case 'a':
                    Dado normal = new(Dados_Enum.normal);
                    puntaje += normal.ObtenerCara();
                    d = normal;
                    break;
                case 'b':
                    Dado octaedro = new(Dados_Enum.octaedro);
                    puntaje += octaedro.ObtenerCara();
                    d=octaedro;
                    break;
                case 'c':
                    Dado decaedro = new(Dados_Enum.decaedro);
                    decaedro.ObtenerCara();
                    d=decaedro;
                    break;
                case 'd':
                    Dado dodecaedro = new(Dados_Enum.dodecaedro);
                    puntaje += dodecaedro.ObtenerCara();
                    d=dodecaedro;
                    break;
                case 'e':
                    com.EnviarDatosServidor(id);
                    Thread.Sleep(500);
                    Console.WriteLine(com.Msg);
                    continue;
                default:
                    Console.WriteLine("No entiendo esa orden");
                    break;
                    
            }
            Console.WriteLine(d.ToString()); //Imprimos la carta que se ha escogido
            //Datos que se van a enviar al servidor
            string datos = d.ToString + "  puntaje :" + d.getCara();

            try
            {
                com.EnviarDatosServidor(datos); //Envío de los datos al servidor

            }
            catch (Exception e) { Console.WriteLine("Algo ocurrio con el servidor!"); }

            Thread.Sleep(200); //Detenemos el hilo principal por 0.2s
            Console.WriteLine(com.Msg); //Mostramos la información de conteo realizada por el servidor

        } while (true);
    }
}