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
    public partial class Práctica12 : Form
    {
        private Queue<Auto> estacionamiento = new Queue<Auto>();

        public Práctica12()
        {
            InitializeComponent();
        }

        private void btnEntradaAuto_Click(object sender, EventArgs e)
        {
            string placas = txtPlacas.Text;
            string propietario = txtPropietario.Text;

            Auto auto = new Auto(placas, propietario);
            estacionamiento.Enqueue(auto);


            MessageBox.Show("Auto registrado en el estacionamiento.");

           
            txtPlacas.Clear();
            txtPropietario.Clear();
        }

        private void btnSalidaAuto_Click(object sender, EventArgs e)
        {
            if (estacionamiento.Count == 0)
            {
                MessageBox.Show("El estacionamiento está vacío.");
                return;
            }

            Auto autoSalida = estacionamiento.Dequeue();
            autoSalida.HoraSalida = DateTime.Now;

            double costo = autoSalida.CalcularCosto();


            string mensaje = $"Placas: {autoSalida.Placas}\nPropietario: {autoSalida.Propietario}\nHora de entrada: {autoSalida.HoraEntrada}\nHora de salida: {autoSalida.HoraSalida}\nCosto: ${costo:F2}";
            MessageBox.Show(mensaje);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Inicio form1 = new Inicio();
            form1.Show();
            this.Close();
        }
    }
}


