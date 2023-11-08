namespace JuegoCoches
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            iniciarJuegoButton = new Button();
            AmarilloButton = new Button();
            panel1 = new Panel();
            fila5Label = new Label();
            fila4Label = new Label();
            fila3Label = new Label();
            fila2Label = new Label();
            fila1Label = new Label();
            pintadoLabel = new Label();
            filaCincoPictureBox = new PictureBox();
            Fila4PictureBox = new PictureBox();
            filaTresPictureBox = new PictureBox();
            filaDosPictureBox = new PictureBox();
            filaUnoPictureBox = new PictureBox();
            atendidoPictureBox = new PictureBox();
            label2 = new Label();
            RojoButton = new Button();
            RosaButton = new Button();
            VerdeButton = new Button();
            NegroButton = new Button();
            AzulButton = new Button();
            MoradoButton = new Button();
            NaranjaButton = new Button();
            timerJuego = new System.Windows.Forms.Timer(components);
            timerInsertCar = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)filaCincoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Fila4PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filaTresPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filaDosPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filaUnoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)atendidoPictureBox).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(120, 22);
            label1.Name = "label1";
            label1.Size = new Size(486, 20);
            label1.TabIndex = 0;
            label1.Text = "Tienes que pintar el coche dependiendo del texto que tienen debajo";
            // 
            // iniciarJuegoButton
            // 
            iniciarJuegoButton.Location = new Point(331, 45);
            iniciarJuegoButton.Name = "iniciarJuegoButton";
            iniciarJuegoButton.Size = new Size(82, 38);
            iniciarJuegoButton.TabIndex = 1;
            iniciarJuegoButton.Text = "Iniciar Juego";
            iniciarJuegoButton.UseVisualStyleBackColor = true;
            iniciarJuegoButton.Click += iniciarJuegoButton_Click;
            // 
            // AmarilloButton
            // 
            AmarilloButton.BackColor = Color.Yellow;
            AmarilloButton.Location = new Point(117, 22);
            AmarilloButton.Name = "AmarilloButton";
            AmarilloButton.Size = new Size(94, 44);
            AmarilloButton.TabIndex = 4;
            AmarilloButton.UseVisualStyleBackColor = false;
            AmarilloButton.Click += amarilloButton_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(fila5Label);
            panel1.Controls.Add(fila4Label);
            panel1.Controls.Add(fila3Label);
            panel1.Controls.Add(fila2Label);
            panel1.Controls.Add(fila1Label);
            panel1.Controls.Add(pintadoLabel);
            panel1.Controls.Add(filaCincoPictureBox);
            panel1.Controls.Add(Fila4PictureBox);
            panel1.Controls.Add(filaTresPictureBox);
            panel1.Controls.Add(filaDosPictureBox);
            panel1.Controls.Add(filaUnoPictureBox);
            panel1.Controls.Add(atendidoPictureBox);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RojoButton);
            panel1.Controls.Add(RosaButton);
            panel1.Controls.Add(VerdeButton);
            panel1.Controls.Add(NegroButton);
            panel1.Controls.Add(AzulButton);
            panel1.Controls.Add(MoradoButton);
            panel1.Controls.Add(NaranjaButton);
            panel1.Controls.Add(AmarilloButton);
            panel1.Location = new Point(12, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 270);
            panel1.TabIndex = 5;
            panel1.Visible = false;
            // 
            // fila5Label
            // 
            fila5Label.AutoSize = true;
            fila5Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fila5Label.Location = new Point(599, 241);
            fila5Label.Name = "fila5Label";
            fila5Label.Size = new Size(57, 19);
            fila5Label.TabIndex = 24;
            fila5Label.Text = "Perdiste";
            // 
            // fila4Label
            // 
            fila4Label.AutoSize = true;
            fila4Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fila4Label.Location = new Point(488, 241);
            fila4Label.Name = "fila4Label";
            fila4Label.Size = new Size(38, 19);
            fila4Label.TabIndex = 23;
            fila4Label.Text = "fila 4";
            fila4Label.Visible = false;
            // 
            // fila3Label
            // 
            fila3Label.AutoSize = true;
            fila3Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fila3Label.Location = new Point(379, 241);
            fila3Label.Name = "fila3Label";
            fila3Label.Size = new Size(38, 19);
            fila3Label.TabIndex = 22;
            fila3Label.Text = "fila 3";
            fila3Label.Visible = false;
            // 
            // fila2Label
            // 
            fila2Label.AutoSize = true;
            fila2Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fila2Label.Location = new Point(276, 241);
            fila2Label.Name = "fila2Label";
            fila2Label.Size = new Size(38, 19);
            fila2Label.TabIndex = 21;
            fila2Label.Text = "fila 2";
            fila2Label.Visible = false;
            // 
            // fila1Label
            // 
            fila1Label.AutoSize = true;
            fila1Label.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fila1Label.Location = new Point(156, 241);
            fila1Label.Name = "fila1Label";
            fila1Label.Size = new Size(38, 19);
            fila1Label.TabIndex = 20;
            fila1Label.Text = "fila 1";
            // 
            // pintadoLabel
            // 
            pintadoLabel.AutoSize = true;
            pintadoLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            pintadoLabel.Location = new Point(42, 241);
            pintadoLabel.Name = "pintadoLabel";
            pintadoLabel.Size = new Size(56, 19);
            pintadoLabel.TabIndex = 19;
            pintadoLabel.Text = "Pintado";
            // 
            // filaCincoPictureBox
            // 
            filaCincoPictureBox.Location = new Point(571, 166);
            filaCincoPictureBox.Name = "filaCincoPictureBox";
            filaCincoPictureBox.Size = new Size(99, 62);
            filaCincoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            filaCincoPictureBox.TabIndex = 18;
            filaCincoPictureBox.TabStop = false;
            filaCincoPictureBox.Visible = false;
            // 
            // Fila4PictureBox
            // 
            Fila4PictureBox.Location = new Point(461, 166);
            Fila4PictureBox.Name = "Fila4PictureBox";
            Fila4PictureBox.Size = new Size(99, 62);
            Fila4PictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            Fila4PictureBox.TabIndex = 17;
            Fila4PictureBox.TabStop = false;
            // 
            // filaTresPictureBox
            // 
            filaTresPictureBox.Location = new Point(348, 166);
            filaTresPictureBox.Name = "filaTresPictureBox";
            filaTresPictureBox.Size = new Size(99, 62);
            filaTresPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            filaTresPictureBox.TabIndex = 16;
            filaTresPictureBox.TabStop = false;
            // 
            // filaDosPictureBox
            // 
            filaDosPictureBox.Location = new Point(241, 166);
            filaDosPictureBox.Name = "filaDosPictureBox";
            filaDosPictureBox.Size = new Size(99, 62);
            filaDosPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            filaDosPictureBox.TabIndex = 15;
            filaDosPictureBox.TabStop = false;
            // 
            // filaUnoPictureBox
            // 
            filaUnoPictureBox.ImageLocation = "";
            filaUnoPictureBox.Location = new Point(126, 166);
            filaUnoPictureBox.Name = "filaUnoPictureBox";
            filaUnoPictureBox.Size = new Size(99, 62);
            filaUnoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            filaUnoPictureBox.TabIndex = 14;
            filaUnoPictureBox.TabStop = false;
            // 
            // atendidoPictureBox
            // 
            atendidoPictureBox.Location = new Point(17, 166);
            atendidoPictureBox.Name = "atendidoPictureBox";
            atendidoPictureBox.Size = new Size(99, 62);
            atendidoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            atendidoPictureBox.TabIndex = 13;
            atendidoPictureBox.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(608, 22);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 12;
            label2.Text = "Tiempo transcurrido: ";
            label2.AutoSizeChanged += iniciarJuegoButton_Click;
            // 
            // RojoButton
            // 
            RojoButton.BackColor = Color.Red;
            RojoButton.Location = new Point(241, 94);
            RojoButton.Name = "RojoButton";
            RojoButton.Size = new Size(94, 44);
            RojoButton.TabIndex = 11;
            RojoButton.UseVisualStyleBackColor = false;
            RojoButton.Click += RojoButton_Click;
            // 
            // RosaButton
            // 
            RosaButton.BackColor = Color.HotPink;
            RosaButton.Location = new Point(364, 94);
            RosaButton.Name = "RosaButton";
            RosaButton.Size = new Size(94, 44);
            RosaButton.TabIndex = 10;
            RosaButton.UseVisualStyleBackColor = false;
            RosaButton.Click += RosaButton_Click;
            // 
            // VerdeButton
            // 
            VerdeButton.BackColor = Color.Lime;
            VerdeButton.Location = new Point(488, 94);
            VerdeButton.Name = "VerdeButton";
            VerdeButton.Size = new Size(94, 44);
            VerdeButton.TabIndex = 9;
            VerdeButton.UseVisualStyleBackColor = false;
            VerdeButton.Click += VerdeButton_Click;
            // 
            // NegroButton
            // 
            NegroButton.BackColor = Color.Black;
            NegroButton.Location = new Point(117, 94);
            NegroButton.Name = "NegroButton";
            NegroButton.Size = new Size(94, 44);
            NegroButton.TabIndex = 8;
            NegroButton.UseVisualStyleBackColor = false;
            NegroButton.Click += NegroButton_Click;
            // 
            // AzulButton
            // 
            AzulButton.BackColor = Color.Blue;
            AzulButton.Location = new Point(241, 22);
            AzulButton.Name = "AzulButton";
            AzulButton.Size = new Size(94, 44);
            AzulButton.TabIndex = 7;
            AzulButton.UseVisualStyleBackColor = false;
            AzulButton.Click += AzulButton_Click;
            // 
            // MoradoButton
            // 
            MoradoButton.BackColor = Color.Purple;
            MoradoButton.Location = new Point(364, 22);
            MoradoButton.Name = "MoradoButton";
            MoradoButton.Size = new Size(94, 44);
            MoradoButton.TabIndex = 6;
            MoradoButton.UseVisualStyleBackColor = false;
            MoradoButton.Click += MoradoButton_Click;
            // 
            // NaranjaButton
            // 
            NaranjaButton.BackColor = Color.DarkOrange;
            NaranjaButton.Location = new Point(488, 22);
            NaranjaButton.Name = "NaranjaButton";
            NaranjaButton.Size = new Size(94, 44);
            NaranjaButton.TabIndex = 5;
            NaranjaButton.UseVisualStyleBackColor = false;
            NaranjaButton.Click += NaranjaButton_Click;
            // 
            // timerJuego
            // 
            timerJuego.Interval = 1000;
            timerJuego.Tick += timerJuego_Tick;
            // 
            // timerInsertCar
            // 
            timerInsertCar.Interval = 1000;
            timerInsertCar.Tick += timerInsertCar_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 421);
            Controls.Add(panel1);
            Controls.Add(iniciarJuegoButton);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)filaCincoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Fila4PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)filaTresPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)filaDosPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)filaUnoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)atendidoPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button iniciarJuegoButton;
        private DataGridViewRow dadada;
        private DataGridViewTextBoxColumn columnMorado;
        private DataGridViewTextBoxColumn columnNaranja;
        private DataGridViewTextBoxColumn columnNegro;
        private DataGridViewTextBoxColumn columnRosa;
        private Button AmarilloButton;
        private Panel panel1;
        private Button AzulButton;
        private Button MoradoButton;
        private Button NaranjaButton;
        private Button RojoButton;
        private Button RosaButton;
        private Button VerdeButton;
        private Button NegroButton;
        private Label label2;
        private System.Windows.Forms.Timer timerJuego;
        private PictureBox filaDosPictureBox;
        private PictureBox filaUnoPictureBox;
        private PictureBox atendidoPictureBox;
        private PictureBox filaCincoPictureBox;
        private PictureBox Fila4PictureBox;
        private PictureBox filaTresPictureBox;
        private Label pintadoLabel;
        private Label fila5Label;
        private Label fila4Label;
        private Label fila3Label;
        private Label fila2Label;
        private Label fila1Label;
        private System.Windows.Forms.Timer timerInsertCar;
    }
}