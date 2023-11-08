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
    public partial class ModalAlumnos : Form
    {
        public string NOmbreAlu {  get; set; }
        public decimal Calif {  get; set; }
        public ModalAlumnos()
        {
            InitializeComponent();
        }

        private void ModalAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal num = 0;
            num += decimal.TryParse(textBox1.Text, out num) ? num : 5;
            num += decimal.TryParse(textBox3.Text, out num) ? num : 5;
            num += decimal.TryParse(textBox4.Text, out num) ? num : 5;

            Calif = num / 3;
            this.Close();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox2.Text == null)
            {
                NOmbreAlu = "NoName";
            }

            else  NOmbreAlu = textBox2.Text;

            panel1.Visible = true;
        }
    }
}
