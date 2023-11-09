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
            Debug.WriteLine("Le diste clic al botón INICIAR");
            string usu = txtUsuario.Text;
            string pwd = txtPassword.Text;
            if (usu.Equals("Pepe") && pwd.Equals("123456"))
            {
                //Mostrar el mensaje "Bienvenido señor Pepe"
                lblMensaje.Text = "Bienvenido señor Pepe";
            }
            else
            {
                txtUsuario.Text = txtPassword.Text = "";
                lblMensaje.Text = "Intente nuevamente";
            }
        }

        private void informacion(object sender, EventArgs e)
        {
            Debug.WriteLine("Le diste clic al botón info");
        }

        private void EventoParaClick(string evento, int tipo)
        {

        }

        private void Pilas() {
            Stack<string> miPila = new Stack<string>();
            //Métodos propios de la pila (en C#)
        }
    }
}   