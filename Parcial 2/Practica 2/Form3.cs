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
    public partial class Form3 : Form
    {
        List<AlumnosCalif> alumnos = new List<AlumnosCalif>();
        public Form3()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            ModalAlumnos modal1 = new ModalAlumnos();
            modal1.ShowDialog();
            AlumnosCalif alumno1 = new AlumnosCalif(modal1.NOmbreAlu);
            alumno1.Calif = modal1.Calif;
            alumnos.Add(alumno1);
            GenerarListas();
        }

        private void GenerarListas()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (var alumno in alumnos)
            {
                if (alumno.Calif >= 7)
                {
                    string texto = alumno.Nombre + "\t" + alumno.Calif.ToString();
                    listBox1.Items.Add(texto);
                }
                else
                {
                    string texto = alumno.Nombre + "\t" + alumno.Calif.ToString();
                    listBox2.Items.Add(texto);
                }
            }
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

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
