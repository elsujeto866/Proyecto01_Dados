using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BibliotecaDados
{
    public class Usuario
    {
         public int  id_num=0;
        public string id;
         public string nombre;
        public int puntaje;
        public Usuario(string nombre) {
            DateTime fechaActual = DateTime.Now;
            id = fechaActual.Year+fechaActual.Month+fechaActual.Day+""+id_num;
            id_num++;
            this.nombre = nombre;  
        }
        public string ObtenerNombre()
        {
            return this.nombre;
        }
        public string ObtenerId()
        {
            return ""+this.id;
        }
        public void SetPuntaje (int puntaje)
        {
            this.puntaje=puntaje;
        }
        public int Obtenerpuntaje()
        {
            return this.puntaje;
        }
    }
    
}
