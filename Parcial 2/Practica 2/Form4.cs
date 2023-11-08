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
    public partial class Form4 : Form
    {
        List<ProductoCodigo> productos = new List<ProductoCodigo>();
        public Form4()
        {
            InitializeComponent();
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Ingrese el nombre del producto";
            panel2.BackColor = Color.MediumPurple;
            panel2.Visible = true;
            ingreNombButton.Visible = true;
            elimButton.Visible = false;
        }

        private void ingreNombButton_Click(object sender, EventArgs e)
        {
            string nombreProducto = textBox1.Text;
            if (nombreProducto == null || nombreProducto == "")
                nombreProducto = "NoName";
            ProductoCodigo producto = new ProductoCodigo(nombreProducto);
            productos.Add(producto);
            panel2.Visible = false;
            ingreNombButton.Visible = false;
            ActualizarCarrito();
        }

        private void eliminarButton_Click(object sender, EventArgs e)
        {
            label1.Text = "Ingrese el codigo del producto (Numero ENTERO)";
            elimButton.Visible = true;
            ingreNombButton.Visible = false;
            panel2.BackColor = Color.HotPink;
            panel2.Visible = true;
        }

        private void elimButton_Click(object sender, EventArgs e)
        {
            int codProducto = int.TryParse(textBox1.Text, out codProducto) ? codProducto : 1;
            var producto = productos.FirstOrDefault(product => product.Codigo == codProducto);

            if (producto == null)
                MessageBox.Show("El codigo es invalido ó el Producto no existe");
            else productos.Remove(producto);
            panel2.Visible = false;
            elimButton.Visible = false;
            ActualizarCarrito();
        }

        // Carrito
        private void ActualizarCarrito()
        {
            listBox1.Items.Clear();
            productos = productos.OrderBy(product => product.Name).ToList();
            string texto;
            decimal total = 0;

            foreach (var producto in productos)
            {
                texto = producto.Name + "\t";
                texto += producto.Price;
                total += (decimal)producto.Price;
                listBox1.Items.Add(texto);
            }

            listBox1.Items.Add("");
            texto = "Total\t" + total;
            listBox1.Items.Add(texto);
        }

        private void compraBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gracias por la compra!!");
            listBox1.Items.Clear();
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

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
