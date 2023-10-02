namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            labelCircPeri.Visible = false;
            labelCircArea.Visible = false;
            labelRecPeri.Visible = false;
            labelRecArea.Visible = false;
            labelTriaArea.Visible = false;
            labelTriaPeri.Visible = false;
            labelCuaArea.Visible = false;
            labelCuaPeri.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            labelCircPeri.Visible = false;
            labelCircArea.Visible = false;
            labelRecPeri.Visible = false;
            labelRecArea.Visible = false;
            labelTriaArea.Visible = false;
            labelTriaPeri.Visible = false;
            labelCuaArea.Visible = false;
            labelCuaPeri.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            panel4.Visible = false;
            labelCircPeri.Visible = false;
            labelCircArea.Visible = false;
            labelRecPeri.Visible = false;
            labelRecArea.Visible = false;
            labelTriaArea.Visible = false;
            labelTriaPeri.Visible = false;
            labelCuaArea.Visible = false;
            labelCuaPeri.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            panel4.Visible = false;
            labelCircPeri.Visible = false;
            labelCircArea.Visible = false;
            labelRecPeri.Visible = false;
            labelRecArea.Visible = false;
            labelTriaArea.Visible = false;
            labelTriaPeri.Visible = false;
            labelCuaArea.Visible = false;
            labelCuaPeri.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = true;
            labelCircPeri.Visible = false;
            labelCircArea.Visible = false;
            labelRecPeri.Visible = false;
            labelRecArea.Visible = false;
            labelTriaArea.Visible = false;
            labelTriaPeri.Visible = false;
            labelCuaArea.Visible = false;
            labelCuaPeri.Visible = false;
        }

        private void btnAreaCirc_Click(object sender, EventArgs e)
        {
            Circulo circulo1 = new Circulo();

            if (!Utilidades.sonLetras(textBox1.Text.Trim()))
            {
                circulo1.Radio = Convert.ToDouble(textBox1.Text.Trim());
                labelCircPeri.Text = Math.Round(circulo1.perimetro(),2).ToString();
                labelCircArea.Text = Math.Round(circulo1.area(),2).ToString();
                labelCircPeri.Visible = true;
                labelCircArea.Visible = true;
            }
            else
            {
                errorProvider1 = new ErrorProvider();
                MessageBox.Show("Se ha producido un error: Ingrese valores numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Rectangulo rectangulo1 = new Rectangulo();

            if (!Utilidades.sonLetras(textBox2.Text.Trim()) && !Utilidades.sonLetras(textBox3.Text.Trim()))
            {
                rectangulo1.Altura = Convert.ToDouble(textBox2.Text.Trim());
                rectangulo1.Bases = Convert.ToDouble(textBox3.Text.Trim());
                labelRecArea.Text = Math.Round(rectangulo1.area(), 2).ToString();
                labelRecPeri.Text = Math.Round(rectangulo1.perimetro(), 2).ToString();
                labelRecArea.Visible = true;
                labelRecPeri.Visible = true;
            }
            else
            {
                errorProvider1 = new ErrorProvider();
                MessageBox.Show("Se ha producido un error: Ingrese valores numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Triangulo triangulo1 = new Triangulo();

            if (!Utilidades.sonLetras(textBox5.Text.Trim()) && !Utilidades.sonLetras(textBox4.Text.Trim()))
            {
                triangulo1.Altura = Convert.ToDouble(textBox5.Text.Trim());
                triangulo1.Bases = Convert.ToDouble(textBox4.Text.Trim());
                labelTriaArea.Text = Math.Round(triangulo1.area(),2).ToString();
                labelTriaPeri.Text = Math.Round(triangulo1.perimetro(),2).ToString();
                labelTriaArea.Visible = true;
                labelTriaPeri.Visible = true;
            }
            else
            {
                errorProvider1 = new ErrorProvider();
                MessageBox.Show("Se ha producido un error: Ingrese valores numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Cuadrado cuadrado1 = new Cuadrado();

            if (!Utilidades.sonLetras(textBox6.Text.Trim()))
            {
                cuadrado1.Bases = Convert.ToDouble(textBox6.Text.Trim());
                labelCuaArea.Text = Math.Round(cuadrado1.area(),2).ToString();
                labelCuaPeri.Text = Math.Round(cuadrado1.perimetro(),2).ToString();
                labelCuaArea.Visible = true;
                labelCuaPeri.Visible = true;
            }
            else
            {
                errorProvider1 = new ErrorProvider();
                MessageBox.Show("Se ha producido un error: Ingrese valores numericos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}