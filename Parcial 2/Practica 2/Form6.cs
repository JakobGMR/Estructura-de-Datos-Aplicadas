using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string texto;

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ingrese un texto valido");
                return;
            }
            else texto = textBox1.Text;

            char[] caracteres = texto.ToCharArray();
            Array.Reverse(caracteres);
            texto = new String(caracteres);

            textBox2.Text = texto;
        }

        public event EventHandler ShowForm1Requested;

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Cuando se haga clic en el botón, activar el evento personalizado
            ShowForm1Requested?.Invoke(this, EventArgs.Empty);
        }

        private void numsAleatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void alumnosAproReprToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void ordenProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void organizarPalabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void palindromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
