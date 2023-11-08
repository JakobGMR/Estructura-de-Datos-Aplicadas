using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2P___A4_Prácticas_Pilas_y_Colas
{
    public partial class Práctica9 : Form
    {
        public Práctica9()
        {
            InitializeComponent();
            Aleatorios();


        }

        Stack<int> pila = new Stack<int>();

        
        private void Aleatorios()
        {
            int cantidadNumeros = 30;
            Random random = new Random();
            listBoxPila.Items.Clear();

            for (int i = 0; i < cantidadNumeros; i++)
            {
                int numeroAleatorio = random.Next(1, 101);
                pila.Push(numeroAleatorio);
                listBoxPila.Items.Add(numeroAleatorio);
            }
        }

        private void Reemplazar(Stack<int> pila, int nuevo, int viejo)
        {
            Stack<int> pilaAux = new Stack<int>();

            while (pila.Count > 0)
            {
                int elemento = pila.Pop();
                if (elemento == viejo)
                {
                    pilaAux.Push(nuevo);
                }
                else
                {
                    pilaAux.Push(elemento);
                }
            }

            foreach (int elemento in pilaAux)
            {
                pila.Push(elemento);
            }
        }
        private void buttonReemplazar_Click_1(object sender, EventArgs e)
        {
            int nuevoValor = int.Parse(textBoxNuevo.Text);
            int valorViejo = int.Parse(textBoxViejo.Text);

            List<int> nuevaPila = pila.ToList();
            pila.Clear();

            for (int i = 0; i < nuevaPila.Count; i++)
            {
                int elemento = nuevaPila[i];
                if (elemento == valorViejo)
                {
                    pila.Push(nuevoValor);
                }
                else
                {
                    pila.Push(elemento);
                }
            }

           

            listBoxPila.Items.Clear();
            foreach (int elemento in pila)
            {
                listBoxPila.Items.Add(elemento);
            }
        }

        private void textBoxNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void textBoxNuevo_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("El campo no debe estar vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
            }
        }

        private void textBoxViejo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }


        private void textBoxViejo_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                MessageBox.Show("El campo no debe estar vacío", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio form1 = new Inicio();
            form1.Show();
            this.Close();
        }
    }
}