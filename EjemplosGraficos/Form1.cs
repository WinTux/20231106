using System.Collections.Generic;
using System.Diagnostics;

namespace EjemplosGraficos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Debug.WriteLine("Le diste clic al bot�n INICIAR");
            string usu = txtUsuario.Text;
            string pwd = txtPassword.Text;
            if (usu.Equals("Pepe") && pwd.Equals("123456"))
            {
                //Mostrar el mensaje "Bienvenido se�or Pepe"
                lblMensaje.Text = "Bienvenido se�or Pepe";
            }
            else
            {
                txtUsuario.Text = txtPassword.Text = "";
                lblMensaje.Text = "Intente nuevamente";
            }
        }

        private void informacion(object sender, EventArgs e)
        {
            Debug.WriteLine("Le diste clic al bot�n info");
        }

        private void EventoParaClick(string evento, int tipo)
        {

        }

        private void Pilas() {
            Stack<string> miPila = new Stack<string>();
            //M�todos propios de la pila (en C#)
        }
    }
}   