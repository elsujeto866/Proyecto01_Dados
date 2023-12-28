
using BibliotecaDados;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Net;
namespace Proyecto1_ErickO_DorianM
{
    public partial class FormPaginaJuego : Form
    {
        //Variables empleadas para el funcionamiento de la clase
        string id; //variable para almacenar el ID de cada cliente, usada para conocer qué cliente realiza la acción de reinciar y cuál carta envia
        string nombre = ""; //variable que almacena el nombre del cliente
        string puntaje = "";  //variable que almacena el puntaje
        string valNombre = ""; //variable para guardar el nombre del cliente
        Dado d; //variable para almacenar la instancia del dado
        IPEndPoint ip; //IPEndPoint para la conexión TCP con el servidor
        ComunicacionServidor com; //variable para instanciar ComunicaciónServidor

        public FormPaginaJuego()
        {
            InitializeComponent();
            listBDados.Items.Add(new Dado(Dados_Enum.normal));
            listBDados.Items.Add(new Dado(Dados_Enum.octaedro));
            listBDados.Items.Add(new Dado(Dados_Enum.decaedro));
            listBDados.Items.Add(new Dado(Dados_Enum.dodecaedro));

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLanzarDado_Click(object sender, EventArgs e)
        {

        }

        private void listBDados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
