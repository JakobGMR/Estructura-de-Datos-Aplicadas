namespace Practica_2
{
    public partial class Form1 : Form
    {
        Form2 form2;
        Form3 form3;
        Form4 form4;
        Form5 form5;
        Form6 form6;
        Form7 form7;

        public Form1()
        {
            InitializeComponent();
            products.Add(new Producto("Shampoo Adc"));
            products.Add(new Producto("Crema de coco"));
            products.Add(new Producto("Cereal Kellogs"));
            string texto = "Nombre \t\t Cantidad \t\t Precio";
            listBox1.Items.Add(texto);

            form2 = new Form2();
            form3 = new Form3();
            form4 = new Form4();
            form5 = new Form5();
            form6 = new Form6();
            form7 = new Form7();
            // Suscribirte al evento personalizado
            form2.ShowForm1Requested += (sender, e) =>
            {
                // Mostrar el formulario principal cuando se active el evento
                this.Show();
            };
            form3.ShowForm1Requested += (sender, e) =>
            {
                // Mostrar el formulario principal cuando se active el evento
                this.Show();
            };
            form4.ShowForm1Requested += (sender, e) =>
            {
                // Mostrar el formulario principal cuando se active el evento
                this.Show();
            };
            form5.ShowForm1Requested += (sender, e) =>
            {
                // Mostrar el formulario principal cuando se active el evento
                this.Show();
            };
            form6.ShowForm1Requested += (sender, e) =>
            {
                // Mostrar el formulario principal cuando se active el evento
                this.Show();
            };
            form7.ShowForm1Requested += (sender, e) =>
            {
                // Mostrar el formulario principal cuando se active el evento
                this.Show();
            };
        }

        private List<Producto> products = new List<Producto>();
        int cantEliminada = 0;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void ingreNombButton_Click(object sender, EventArgs e)
        {
            string nombreProducto = textBox1.Text;
            if (nombreProducto == null || nombreProducto == "")
                nombreProducto = "NoName";
            Producto producto = new Producto(nombreProducto);
            products.Add(producto);
            panel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            panel4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombreProducto = textBox1.Text;
            if (nombreProducto == null || nombreProducto == "")
                nombreProducto = "NoName";
            var product = products.FirstOrDefault(producto => producto.Name == nombreProducto);

            if (product != null)
            {
                products.Remove(product);
                cantEliminada++;
            }
            panel3.Visible = false;
        }

        private void mostrarButton_Click(object sender, EventArgs e)
        {
            mostrarDatos();
            panel4.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
        }

        private void ocultarButton_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
        }

        // Cargar datos
        private void mostrarDatos()
        {
            listBox1.Items.Clear();
            foreach (var producto in products)
            {
                string texto = "";
                texto += producto.Name;
                texto += "\t" + producto.Qty;
                texto += "\t" + producto.Price;
                listBox1.Items.Add(texto);
            }

            listBox1.Items.Add("");
            string texto2 = "Cantidad de productos: " + Convert.ToString(products.Count);
            listBox1.Items.Add(texto2);
            listBox1.Items.Add("");
            texto2 = "Productos eliminados: " + Convert.ToString(cantEliminada);
            listBox1.Items.Add(texto2);
        }

        private void numsAleatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            this.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void alumnosAproReprToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void ordenProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 form4 = new Form4();
            form4.Show();
        }

        private void organizarPalabrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 form5 = new Form5();
            form5.Show();
        }

        private void invertirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void palindromoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}