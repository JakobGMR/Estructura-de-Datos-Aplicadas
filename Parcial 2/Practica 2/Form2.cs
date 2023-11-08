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
    public partial class Form2 : Form
    {
        public event EventHandler ShowForm1Requested; // Para mostrar solo el Forms1
        public Form2()
        {
            InitializeComponent();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void generarButton_Click(object sender, EventArgs e)
        {
            LimpiarListas();
            NumsAleatorios numsRandom = new NumsAleatorios();
            numsRandom.GenerarNums();
            string fila = "";

            listBox1.Items.Add("20 Numeros Generados Aleatoriamente");
            listBox1.Items.Add("");

            for (int i = 0; i < 20; i++)
            {
                fila += Convert.ToString(numsRandom.Numeros[i] + "\t");
                if (i == 4 || i == 9 || i == 14 || i == 19)
                {
                    listBox1.Items.Add(fila);
                    fila = "";
                }
            }

            AcomodarParInpar(numsRandom.Pares, paresListBox);
            AcomodarParInpar(numsRandom.Inpares, inparesListBox);

            listBox1.Visible = true;
            paresListBox.Visible = true;
            inparesListBox.Visible = true;
        }

        private void LimpiarListas()
        {
            listBox1.Items.Clear();
            paresListBox.Items.Clear();
            inparesListBox.Items.Clear();
        }

        private void AcomodarParInpar(List<decimal> lista, ListBox listBox)
        {
            string fila = "";

            for (int i = 0; i < lista.Count(); i++)
            {
                if (lista.Count() >= 3)
                {
                    fila += Convert.ToString(lista[i] + "\t");
                    if (i == 3 || i == 7 || i == 11 || i == 15 || i == 19)
                    {
                        listBox.Items.Add(fila);
                        fila = "";
                    }
                }
                else
                {
                    listBox.Items.Add(lista[i].ToString());
                }
            }
        }

        private void inparesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void alumnosAproReprToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void productosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            // Cuando se haga clic en el botón, activar el evento personalizado
            ShowForm1Requested?.Invoke(this, EventArgs.Empty);
            this.Hide();
        }

        private void alumnosAproReprToolStripMenuItem_Click_1(object sender, EventArgs e)
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
    }
}
