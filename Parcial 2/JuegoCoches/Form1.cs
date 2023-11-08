namespace JuegoCoches
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int cochesPintados = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void iniciarJuegoButton_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            tiempoTotal = 0;
            tiempoCocheNuevo = 20;
            GenerarCoches();
            timerJuego.Start();
            timerInsertCar.Start();
            iniciarJuegoButton.Visible = false;
        }

        private int tiempoTotal;
        private int tiempoCocheNuevo;

        private void timerJuego_Tick(object sender, EventArgs e)
        {
            tiempoTotal++;

            // Actualiza el Label para mostrar el tiempo Total
            label2.Text = "Tiempo transcurrido: " + tiempoTotal.ToString() + " segundos";
        }

        private void PrintCoches()
        {
            if (colaCoches.Count == 1)
            {
                filaDosPictureBox.Visible = false;
                filaTresPictureBox.Visible = false;
                Fila4PictureBox.Visible = false;
                fila2Label.Visible = false;
                fila3Label.Visible = false;
                fila4Label.Visible = false;

                filaUnoPictureBox.Image = colaCoches.ToList()[0].imgCol;
                fila1Label.Text = colaCoches.ToList()[0].Color;
            }

            else if (colaCoches.Count == 2)
            {
                filaDosPictureBox.Visible = true;
                filaTresPictureBox.Visible = false;
                Fila4PictureBox.Visible = false;
                fila2Label.Visible = true;
                fila3Label.Visible = false;
                fila4Label.Visible = false;

                filaUnoPictureBox.Image = colaCoches.ToList()[0].imgCol;
                fila1Label.Text = colaCoches.ToList()[0].Color;
                filaDosPictureBox.Image = colaCoches.ToList()[1].imgCol;
                fila2Label.Text = colaCoches.ToList()[1].Color;
            }

            else if (colaCoches.Count == 3)
            {
                filaDosPictureBox.Visible = true;
                filaTresPictureBox.Visible = true;
                Fila4PictureBox.Visible = false;
                fila2Label.Visible = true;
                fila3Label.Visible = true;
                fila4Label.Visible = false;

                filaUnoPictureBox.Image = colaCoches.ToList()[0].imgCol;
                fila1Label.Text = colaCoches.ToList()[0].Color;
                filaDosPictureBox.Image = colaCoches.ToList()[1].imgCol;
                fila2Label.Text = colaCoches.ToList()[1].Color;
                filaTresPictureBox.Image = colaCoches.ToList()[2].imgCol;
                fila3Label.Text = colaCoches.ToList()[2].Color;
            }

            else if (colaCoches.Count == 4)
            {
                filaDosPictureBox.Visible = true;
                filaTresPictureBox.Visible = true;
                Fila4PictureBox.Visible = true;
                fila2Label.Visible = true;
                fila3Label.Visible = true;
                fila4Label.Visible = true;

                filaUnoPictureBox.Image = colaCoches.ToList()[0].imgCol;
                fila1Label.Text = colaCoches.ToList()[0].Color;
                filaDosPictureBox.Image = colaCoches.ToList()[1].imgCol;
                fila2Label.Text = colaCoches.ToList()[1].Color;
                filaTresPictureBox.Image = colaCoches.ToList()[2].imgCol;
                fila3Label.Text = colaCoches.ToList()[2].Color;
                Fila4PictureBox.Image = colaCoches.ToList()[3].imgCol;
                fila4Label.Text = colaCoches.ToList()[3].Color;
            }

            else if (colaCoches.Count == 5)
            {
                filaUnoPictureBox.Image = colaCoches.ToList()[0].imgCol;
                fila1Label.Text = colaCoches.ToList()[0].Color;
                filaDosPictureBox.Image = colaCoches.ToList()[1].imgCol;
                fila2Label.Text = colaCoches.ToList()[1].Color;
                filaTresPictureBox.Image = colaCoches.ToList()[2].imgCol;
                fila3Label.Text = colaCoches.ToList()[2].Color;
                Fila4PictureBox.Image = colaCoches.ToList()[3].imgCol;
                fila4Label.Text = colaCoches.ToList()[3].Color;
                filaCincoPictureBox.Image = colaCoches.ToList()[4].imgCol;
            }
        }

        private void Pintado()
        {
            string ubiImg = "../../../Img/imgCar";
            if (colaCoches.Peek().Color == "Morado" || colaCoches.Peek().Color == "Rojo" || colaCoches.Peek().Color == "Verde")
            {
                ubiImg += colaCoches.Peek().Color + ".jpg";
            }

            else
            {
                ubiImg += colaCoches.Peek().Color + ".png";
            }
            Image img = Image.FromFile(ubiImg);
            atendidoPictureBox.Image = img;
            atendidoPictureBox.Visible = true;

            colaCoches.Dequeue();
            cochesPintados++;
            PrintCoches();
        }

        private void GenerarCoches()
        {
            Coche cocheNuevo = new Coche();
            colaCoches.Enqueue(cocheNuevo);
            PrintCoches();

        }

        private Queue<Coche> colaCoches = new Queue<Coche>();

        private void timerInsertCar_Tick(object sender, EventArgs e)
        {
            tiempoCocheNuevo--;

            if (colaCoches.Count == 0)
            {
                Coche cocheNuevo = new Coche();
                colaCoches.Enqueue(cocheNuevo);
                PrintCoches();
            }

            if (tiempoCocheNuevo <= 0)
            {
                if (cochesPintados < 3)
                {
                    timerInsertCar.Stop();
                    GenerarCoches();
                    tiempoCocheNuevo = 20;
                    timerInsertCar.Start();
                    Perdio();
                }

                else if (cochesPintados >= 3 && cochesPintados < 6)
                {
                    timerInsertCar.Stop();
                    GenerarCoches();
                    tiempoCocheNuevo = 15;
                    timerInsertCar.Start();
                    Perdio();
                }

                else if (cochesPintados >= 6 && cochesPintados < 9)
                {
                    timerInsertCar.Stop();
                    GenerarCoches();
                    tiempoCocheNuevo = 10;
                    timerInsertCar.Start();
                    Perdio();
                }

                else if (cochesPintados >= 9 && cochesPintados < 12)
                {
                    timerInsertCar.Stop();
                    GenerarCoches();
                    tiempoCocheNuevo = 5;
                    timerInsertCar.Start();
                    Perdio();
                }

                else if (cochesPintados >= 12 && cochesPintados < 15)
                {
                    timerInsertCar.Stop();
                    GenerarCoches();
                    tiempoCocheNuevo = 2;
                    timerInsertCar.Start();
                    Perdio();
                }

                else
                {
                    timerInsertCar.Stop();
                    GenerarCoches();
                    tiempoCocheNuevo = 1;
                    timerInsertCar.Start();
                    Perdio();
                }

            }
        }

        private void Perdio()
        {
            if (colaCoches.Count == 5)
            {
                filaCincoPictureBox.Visible = true;
                timerInsertCar.Stop();
                timerJuego.Stop();

                MessageBox.Show("Llenaste la cola!! Haz perdido el juego\n\n"
                              + "Coches pintados: " + cochesPintados
                              + "\nSegundos transcurridos: " + tiempoTotal, "FIN DEL JUEGO");

                Reset();
            }
        }

        private void Reset()
        {
            timerInsertCar.Stop();
            timerJuego.Stop();
            panel1.Visible = false;
            iniciarJuegoButton.Visible = true;
            colaCoches.Clear();
            cochesPintados = 0;
            filaCincoPictureBox.Visible = false;
            atendidoPictureBox.Visible = false;
        }

        private void amarilloButton_Click(object sender, EventArgs e)
        {
            if (colaCoches.Peek().Color == "Amarillo") Pintado();
        }

        private void AzulButton_Click(object sender, EventArgs e)
        {
            if (colaCoches.Peek().Color == "Azul") Pintado();
        }

        private void MoradoButton_Click(object sender, EventArgs e)
        {
            if (colaCoches.Peek().Color == "Morado") Pintado();
        }

        private void NaranjaButton_Click(object sender, EventArgs e)
        {
            if (colaCoches.Peek().Color == "Naranja") Pintado();
        }

        private void NegroButton_Click(object sender, EventArgs e)
        {
            if (colaCoches.Peek().Color == "Negro") Pintado();
        }

        private void RojoButton_Click(object sender, EventArgs e)
        {
            if (colaCoches.Peek().Color == "Rojo") Pintado();
        }

        private void RosaButton_Click(object sender, EventArgs e)
        {
            if (colaCoches.Peek().Color == "Rosa") Pintado();
        }

        private void VerdeButton_Click(object sender, EventArgs e)
        {
            if (colaCoches.Peek().Color == "Verde") Pintado();
        }
    }
}