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
    public partial class ModalPalabras : Form
    {
        public string Palabra { get; set; }
        public ModalPalabras()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                Palabra = "NoName";
            else  Palabra = textBox1.Text;

            this.Close();
        }
    }
}
