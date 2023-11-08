using System;
using _2P___A4_Prácticas_Pilas_y_Colas;
using Clientes;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2P___A4_Prácticas_Pilas_y_Colas
{
    public partial class Práctica10 : Form
    {
        public Práctica10()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            ActualizarTurno();


            turnoAtendidoLabel.Text = "Turno Atendido: ";
            turnoActualLabel.Text = "Turno Actual: ";

        }

        Queue<Cliente> colaClientes = new Queue<Cliente>();
        static int turno = 1;

        private void agregarButton_Click_1(object sender, EventArgs e)
        {
            string nombreCli = "NoName";
            if (string.IsNullOrEmpty(nombreClientetextBox.Text))
            {
                MessageBox.Show("Rellene los campos");
            }
            else
            {
                nombreCli = nombreClientetextBox.Text;
            }

            string mov = comboBox1.SelectedItem.ToString();
            Cliente cliente1 = new Cliente(nombreCli, mov, turno);
            string textoBox = "No Turno: " + turno
                            + "\nNombre: " + nombreCli
                            + "\nTipo movimiento: " + mov
                            + "\nLlegada: " + cliente1.Llegada;
            MessageBox.Show(textoBox, "Agregado a la cola");
            turno++;
            ActualizarTurno();
            colaClientes.Enqueue(cliente1);
            ActualizarTabla();
        }

        private void ActualizarTurno()
        {
            NumTurnotextBox.Text = turno.ToString();
        }

        private void ActualizarTabla()
        {
            dataGridView1.Rows.Clear();

            foreach (var cliente in colaClientes)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = cliente.Turno });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = cliente.Nombre });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = cliente.Movimiento });
                fila.Cells.Add(new DataGridViewTextBoxCell { Value = cliente.Llegada.ToShortTimeString() });

                dataGridView1.Rows.Add(fila);
            }
        }

        private void atenderButton_Click_1(object sender, EventArgs e)
        {
            if (EsVacia())
                MessageBox.Show("La cola esta vacia");
            else
            {
                Cliente cliente = colaClientes.Peek();
                DateTime actual = DateTime.Now;
                TimeSpan diferencia = actual.Subtract(cliente.Llegada);

                turnoAtendidoLabel.Text = "Turno pasado: " + cliente.Turno;

                string texto = "Cliente atendido: " + cliente.Nombre
                             + "\nTiempo de espera: " + diferencia.TotalMinutes.ToString("N2") + " minutos";
                MessageBox.Show(texto, "Tiempo de espera");
                colaClientes.Dequeue();
                ActualizarTabla();

            }

            if (!EsVacia())
            {
                Cliente siguienteCliente = colaClientes.Peek();
                turnoActualLabel.Text = "Turno Actual: " + siguienteCliente.Turno;
            }
            else
            {
                turnoActualLabel.Text = "Turno Actual: -";
            }

        }

        private bool EsVacia()
        {
            if (colaClientes.Count == 0)
            {
                return true;
            }
            else return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio form1 = new Inicio();
            form1.Show();
            this.Close();

        }
    }
}
