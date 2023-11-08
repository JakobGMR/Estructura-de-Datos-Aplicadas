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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Práctica9 form3 = new Práctica9();
            form3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Práctica10 Practica10 = new Práctica10();
            Practica10.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Práctica11 Practica11 = new Práctica11();
            Practica11.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Práctica12 Practica12 = new Práctica12();
            Practica12.Show();
            this.Hide();
        }
    }
}
