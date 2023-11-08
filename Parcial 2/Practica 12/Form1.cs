using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica_12
{
    public partial class Form1 : Form
    {
        private Queue<Auto> estacionamiento = new Queue<Auto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntradaAuto_Click(object sender, EventArgs e)
        {
            string placas = txtPlacas.Text;
            string propietario = txtPropietario.Text;

            if (string.IsNullOrEmpty(placas) || string.IsNullOrEmpty(propietario))
            {
                MessageBox.Show("Rellene los campos","Datos invalidos");
                return;
            }

            if (ExistePlaca(placas))
            {
                MessageBox.Show("Ya EXISTE un coche registrado con esa placa","Registro INVALIDO");
                txtPlacas.Clear();
                txtPropietario.Clear();
                return;
            }

            Auto auto = new Auto(placas, propietario);
            estacionamiento.Enqueue(auto);

            string mensaje = $"Placas: {auto.Placas}\n" +
                             $"Propietario: {auto.Propietario}\n" +
                             $"Hora de entrada: {auto.HoraEntrada}";

            MessageBox.Show(mensaje, "REGISTRO");

            txtPlacas.Clear();
            txtPropietario.Clear();
        }

        private bool ExistePlaca(string placas)
        {
            foreach (var carro in estacionamiento)
            {
                if (carro.Placas.ToLower() == placas.ToLower())
                    return true;
            }

            return false;
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
    }
}


