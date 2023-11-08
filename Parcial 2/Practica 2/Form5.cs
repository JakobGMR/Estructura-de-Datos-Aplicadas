using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_2
{
    public partial class Form5 : Form
    {
        List<string> palabras = new List<string>();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ModalPalabras modal1 = new ModalPalabras();
            modal1.ShowDialog();
            palabras.Add(modal1.Palabra);
            MostrarLista();
            ListaOrdenada();
        }

        private void MostrarLista()
        {
            allPalabrasTextBox.Items.Clear();
            foreach (var palabra in palabras)
            {
                allPalabrasTextBox.Items.Add(palabra);
                //allPalabrasTextBox.Items.Add("");
            }
        }

        private void ListaOrdenada()
        {
            List<string> listaOdernada = new List<string>();
            listaOdernada = palabras.Order().ToList();
            palabOrdenListBox.Items.Clear();
            string text = listaOdernada[0][0].ToString() + "-----------";
            palabOrdenListBox.Items.Add(text);

            for (int i = 0; i < listaOdernada.Count - 1; i++)
            {
                if (listaOdernada[i][0] == listaOdernada[i + 1][0])
                {
                    palabOrdenListBox.Items.Add(listaOdernada[i]);
                }
                else
                {
                    palabOrdenListBox.Items.Add(listaOdernada[i]);
                    text = listaOdernada[i + 1][0].ToString() + "-----------";
                    palabOrdenListBox.Items.Add(text);
                }
            }
            int ultimo = listaOdernada.Count;
            palabOrdenListBox.Items.Add(listaOdernada[ultimo - 1]);
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
            this.Close();
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

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void palindromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
            this.Hide();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
