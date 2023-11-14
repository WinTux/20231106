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

        private void Pilas()
        {
            Stack<string> miPila = new Stack<string>();
            //Métodos propios de la pila (en C#)
            int cant = miPila.Count;
            miPila.Push("Ana");
            miPila.Push("Pepe");
            miPila.Push("Samantha");
            Console.WriteLine(miPila);
            txtContenidoPila.Text = miPila.ToString();
            Stack<string> aux = new Stack<string>();
            while (miPila.Count > 0)
            {

                string elemento = miPila.Pop();
                label3.Text += "\n" + elemento;
                aux.Push(elemento);
            }
            while (aux.Count > 0)
            {
                miPila.Push(aux.Pop());

            }
            label3.Text += "\nElemento de cima: " + miPila.Peek();
            label3.Text += "\nCantidad de elementos: " + miPila.Count;

        }
        private void Colas()
        {
            Queue<string> colaNombres = new Queue<string>();
            //Métodos propios de la pila (en C#)
            int cant = colaNombres.Count;
            colaNombres.Enqueue("Ana");
            colaNombres.Enqueue("Pepe");
            colaNombres.Enqueue("Samantha");
            Console.WriteLine(colaNombres);
            label4.Text = colaNombres.ToString();
            Queue<string> aux = new Queue<string>();
            while (colaNombres.Count > 0)
            {

                string elemento = colaNombres.Dequeue();
                label4.Text += "\n" + elemento;
                aux.Enqueue(elemento);
            }
            while (aux.Count > 0)
            {
                colaNombres.Enqueue(aux.Dequeue());

            }
            label4.Text += "\nElemento delante: " + colaNombres.Peek();
            label4.Text += "\nCantidad de elementos: " + colaNombres.Count;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pilas();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Colas();
        }

        public void EjemploPaseReferenciaValor()
        {
            int edad = 45;
            manipuladorDeNumeros(edad);
            label6.Text = edad + "";
        }

        private void manipuladorDeNumeros(int edad)
        {
            edad = 10;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EjemploPaseReferenciaValor();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            EjemploPorReferencia();
        }

        private void EjemploPorReferencia()
        {
            Persona per = new Persona()
            {
                edad = 21,
                nombre = "Pepe",
                estatura = 1.7
            };
            //referencia
            Persona per_aux = per;
            per.nombre = "";
            per.edad = 80;
            manipuladorDeObjetoPersona(per);
            label7.Text = string.Format("{0} tiene {1} años con estatura {2}", per.nombre, per.edad, per.estatura);
        }

        private void manipuladorDeObjetoPersona(Persona p)
        {
            p.edad = 90;
            p.nombre = "Samantha";
            p.estatura = 1.63;
        }

        private void usandoListas()
        {
            List<string> listaPersona = new List<string>();
            Persona persona = new Persona
            {
                edad = 20,
                nombre = "Samantha",
                estatura = 1.6
            };

            Persona persona2 = new Persona
            {
                edad = 20,
                nombre = "Samantha",
                estatura = 1.6
            };
            listaPersona.Add(persona + "");
            listaPersona.Add(persona + "");
            listaPersona.Add(persona + "");

            listaPersona.Contains(persona2 + "");//Funciona con primitivas, no funciona con objetos compuestos.

            foreach (string per in listaPersona)
            {
                label8.Text += "\n" + per;
            }

            string p = listaPersona.ElementAt(2);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            usandoListas();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //label9.Text = (int.Parse(textBox1.Text) + int.Parse(textBox2.Text)) + "";
            int n1, n2;
            if (int.TryParse(textBox1.Text, out n1)) { //Si es convertible a numero
                // el primer numero es valido
                if (int.TryParse(textBox2.Text, out n2))
                {
                    // el segundo es válido
                    label9.Text = (n1 + n2) + "";
                }
                else { label9.Text = "El segundo valor no es un entero."; }
            }
            else { label9.Text = "El primer valor no es un entero."; }

            int contador = 10;
            while (contador > 0) {
                label9.Text += "\n" + "Hola";
                contador--;
            }
        }
    }

    public class Persona
    {
        public string nombre { get; set; }
        public int edad { get; set; }
        public double estatura { get; set; }

        public override string ToString()
        {
            return $"Mi nombre es {nombre}, tengo {edad} años y mido {estatura} metros.";
        }
    }
}