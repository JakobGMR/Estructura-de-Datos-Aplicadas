namespace Practica_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            ActualizarTurno();
        }

        Queue<Cliente> colaClientes = new Queue<Cliente>();
        static int turno = 1;

        private void agregarButton_Click(object sender, EventArgs e)
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

            string mov = comboBox1.SelectedItem.ToString()!;
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

        private void atenderButton_Click(object sender, EventArgs e)
        {
            if (EsVacia())
                MessageBox.Show("La cola esta vacia");
            else
            {
                Cliente cliente = colaClientes.Peek();
                DateTime actual = DateTime.Now;
                TimeSpan diferencia = actual.Subtract(cliente.Llegada);
                string texto = "Cliente atendido: " + cliente.Nombre
                             + "\nTiempo de espera: " + diferencia.TotalMinutes.ToString("N2") + " minutos";
                MessageBox.Show(texto, "Tiempo de espera");
                colaClientes.Dequeue();
                ActualizarTabla();
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
    }
}