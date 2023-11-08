using System.Windows.Forms;

namespace Pratica11_12_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;

        }
        ManualResetEvent pausaEvent = new ManualResetEvent(true); // Inicialmente, no bloquea el flujo.

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            FilasIn.Visible = false;
            ColumnasIn.Visible = false;
            Generar.Visible = false;
            listBox4.Visible = false;
        }

        private void btUno_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            PracticaOnce arreglo = new PracticaOnce();

            arreglo.PintarArreglo(listBox1);




            listBox1.Items.Add("\n");
            double[] arregloSumaFila = arreglo.SumarArregloFila();
            double[] arregloPromedioFila = arreglo.PromedioArregloFila();

            arreglo.MostrarArreglo(arregloSumaFila, arregloPromedioFila, listBox1);



            listBox1.Items.Add("\n");

            double[] arregloSumaColumna = arreglo.SumarArregloColumna();
            double[] arregloPromedioColumna = arreglo.PromedioArregloColumna();

            arreglo.DibujarArreglo(arregloSumaColumna, arregloPromedioColumna, listBox1);
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
            panel3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            FilasIn.Visible = false;
            ColumnasIn.Visible = false;
            Generar.Visible = false;
            listBox4.Visible = false;

        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            PracticaDoce arreglo = new PracticaDoce();

            arreglo.PintarArreglo(listBox2);
            listBox2.Items.Add("\n");
            arreglo.BuscarVentaMinMax(listBox2);
            listBox2.Items.Add("\n");
            arreglo.SumaTotal(listBox2);
            listBox2.Items.Add("\n");

            arreglo.SumarColumnas(listBox2);
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            PracticaTrece arreglo = new PracticaTrece();

            arreglo.PintarArreglo(listBox3);

            arreglo.PromedioAlumno(listBox3);
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            FilasIn.Visible = false;
            ColumnasIn.Visible = false;
            Generar.Visible = false;
            listBox4.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            FilasIn.Visible = true;
            ColumnasIn.Visible = true;
            Generar.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void Generar_Click(object sender, EventArgs e)
        {
            int filas = (int)FilasIn.Value;
            int columnas = (int)ColumnasIn.Value;
            CuadroMagico cuadro1 = new CuadroMagico(filas, columnas);

            if (cuadro1.CuadroCuadrado())
            {
                cuadro1.RellenarValores();
                cuadro1.PrintArray(listBox4);
                listBox4.Visible = true;
            }

            else return;
        }
    }
}