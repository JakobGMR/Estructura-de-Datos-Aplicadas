using System.Drawing;
using System.Windows.Forms;

namespace _2P___A4_Prácticas_Pilas_y_Colas
{
    partial class Práctica11
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.iniciarJuegoButton = new System.Windows.Forms.Button();
            this.AmarilloButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fila5Label = new System.Windows.Forms.Label();
            this.fila4Label = new System.Windows.Forms.Label();
            this.fila3Label = new System.Windows.Forms.Label();
            this.fila2Label = new System.Windows.Forms.Label();
            this.fila1Label = new System.Windows.Forms.Label();
            this.pintadoLabel = new System.Windows.Forms.Label();
            this.filaCincoPictureBox = new System.Windows.Forms.PictureBox();
            this.Fila4PictureBox = new System.Windows.Forms.PictureBox();
            this.filaTresPictureBox = new System.Windows.Forms.PictureBox();
            this.filaDosPictureBox = new System.Windows.Forms.PictureBox();
            this.filaUnoPictureBox = new System.Windows.Forms.PictureBox();
            this.atendidoPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.RojoButton = new System.Windows.Forms.Button();
            this.RosaButton = new System.Windows.Forms.Button();
            this.VerdeButton = new System.Windows.Forms.Button();
            this.NegroButton = new System.Windows.Forms.Button();
            this.AzulButton = new System.Windows.Forms.Button();
            this.MoradoButton = new System.Windows.Forms.Button();
            this.NaranjaButton = new System.Windows.Forms.Button();
            this.timerJuego = new System.Windows.Forms.Timer(this.components);
            this.timerInsertCar = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filaCincoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fila4PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filaTresPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filaDosPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filaUnoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendidoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(103, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(486, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tienes que pintar el coche dependiendo del texto que tienen debajo";
            // 
            // iniciarJuegoButton
            // 
            this.iniciarJuegoButton.Location = new System.Drawing.Point(284, 39);
            this.iniciarJuegoButton.Name = "iniciarJuegoButton";
            this.iniciarJuegoButton.Size = new System.Drawing.Size(70, 33);
            this.iniciarJuegoButton.TabIndex = 1;
            this.iniciarJuegoButton.Text = "Iniciar Juego";
            this.iniciarJuegoButton.UseVisualStyleBackColor = true;
            this.iniciarJuegoButton.Click += new System.EventHandler(this.iniciarJuegoButton_Click_1);
            // 
            // AmarilloButton
            // 
            this.AmarilloButton.BackColor = System.Drawing.Color.Yellow;
            this.AmarilloButton.Location = new System.Drawing.Point(100, 19);
            this.AmarilloButton.Name = "AmarilloButton";
            this.AmarilloButton.Size = new System.Drawing.Size(81, 38);
            this.AmarilloButton.TabIndex = 4;
            this.AmarilloButton.UseVisualStyleBackColor = false;
            this.AmarilloButton.Click += new System.EventHandler(this.AmarilloButton_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.fila5Label);
            this.panel1.Controls.Add(this.fila4Label);
            this.panel1.Controls.Add(this.fila3Label);
            this.panel1.Controls.Add(this.fila2Label);
            this.panel1.Controls.Add(this.fila1Label);
            this.panel1.Controls.Add(this.pintadoLabel);
            this.panel1.Controls.Add(this.filaCincoPictureBox);
            this.panel1.Controls.Add(this.Fila4PictureBox);
            this.panel1.Controls.Add(this.filaTresPictureBox);
            this.panel1.Controls.Add(this.filaDosPictureBox);
            this.panel1.Controls.Add(this.filaUnoPictureBox);
            this.panel1.Controls.Add(this.atendidoPictureBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.RojoButton);
            this.panel1.Controls.Add(this.RosaButton);
            this.panel1.Controls.Add(this.VerdeButton);
            this.panel1.Controls.Add(this.NegroButton);
            this.panel1.Controls.Add(this.AzulButton);
            this.panel1.Controls.Add(this.MoradoButton);
            this.panel1.Controls.Add(this.NaranjaButton);
            this.panel1.Controls.Add(this.AmarilloButton);
            this.panel1.Location = new System.Drawing.Point(10, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 234);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // fila5Label
            // 
            this.fila5Label.AutoSize = true;
            this.fila5Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fila5Label.Location = new System.Drawing.Point(513, 209);
            this.fila5Label.Name = "fila5Label";
            this.fila5Label.Size = new System.Drawing.Size(57, 19);
            this.fila5Label.TabIndex = 24;
            this.fila5Label.Text = "Perdiste";
            // 
            // fila4Label
            // 
            this.fila4Label.AutoSize = true;
            this.fila4Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fila4Label.Location = new System.Drawing.Point(418, 209);
            this.fila4Label.Name = "fila4Label";
            this.fila4Label.Size = new System.Drawing.Size(38, 19);
            this.fila4Label.TabIndex = 23;
            this.fila4Label.Text = "fila 4";
            this.fila4Label.Visible = false;
            // 
            // fila3Label
            // 
            this.fila3Label.AutoSize = true;
            this.fila3Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fila3Label.Location = new System.Drawing.Point(325, 209);
            this.fila3Label.Name = "fila3Label";
            this.fila3Label.Size = new System.Drawing.Size(38, 19);
            this.fila3Label.TabIndex = 22;
            this.fila3Label.Text = "fila 3";
            this.fila3Label.Visible = false;
            // 
            // fila2Label
            // 
            this.fila2Label.AutoSize = true;
            this.fila2Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fila2Label.Location = new System.Drawing.Point(237, 209);
            this.fila2Label.Name = "fila2Label";
            this.fila2Label.Size = new System.Drawing.Size(38, 19);
            this.fila2Label.TabIndex = 21;
            this.fila2Label.Text = "fila 2";
            this.fila2Label.Visible = false;
            // 
            // fila1Label
            // 
            this.fila1Label.AutoSize = true;
            this.fila1Label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.fila1Label.Location = new System.Drawing.Point(134, 209);
            this.fila1Label.Name = "fila1Label";
            this.fila1Label.Size = new System.Drawing.Size(38, 19);
            this.fila1Label.TabIndex = 20;
            this.fila1Label.Text = "fila 1";
            // 
            // pintadoLabel
            // 
            this.pintadoLabel.AutoSize = true;
            this.pintadoLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.pintadoLabel.Location = new System.Drawing.Point(36, 209);
            this.pintadoLabel.Name = "pintadoLabel";
            this.pintadoLabel.Size = new System.Drawing.Size(56, 19);
            this.pintadoLabel.TabIndex = 19;
            this.pintadoLabel.Text = "Pintado";
            // 
            // filaCincoPictureBox
            // 
            this.filaCincoPictureBox.Location = new System.Drawing.Point(489, 144);
            this.filaCincoPictureBox.Name = "filaCincoPictureBox";
            this.filaCincoPictureBox.Size = new System.Drawing.Size(85, 54);
            this.filaCincoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filaCincoPictureBox.TabIndex = 18;
            this.filaCincoPictureBox.TabStop = false;
            this.filaCincoPictureBox.Visible = false;
            // 
            // Fila4PictureBox
            // 
            this.Fila4PictureBox.Location = new System.Drawing.Point(395, 144);
            this.Fila4PictureBox.Name = "Fila4PictureBox";
            this.Fila4PictureBox.Size = new System.Drawing.Size(85, 54);
            this.Fila4PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Fila4PictureBox.TabIndex = 17;
            this.Fila4PictureBox.TabStop = false;
            // 
            // filaTresPictureBox
            // 
            this.filaTresPictureBox.Location = new System.Drawing.Point(298, 144);
            this.filaTresPictureBox.Name = "filaTresPictureBox";
            this.filaTresPictureBox.Size = new System.Drawing.Size(85, 54);
            this.filaTresPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filaTresPictureBox.TabIndex = 16;
            this.filaTresPictureBox.TabStop = false;
            // 
            // filaDosPictureBox
            // 
            this.filaDosPictureBox.Location = new System.Drawing.Point(207, 144);
            this.filaDosPictureBox.Name = "filaDosPictureBox";
            this.filaDosPictureBox.Size = new System.Drawing.Size(85, 54);
            this.filaDosPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filaDosPictureBox.TabIndex = 15;
            this.filaDosPictureBox.TabStop = false;
            // 
            // filaUnoPictureBox
            // 
            this.filaUnoPictureBox.ImageLocation = "";
            this.filaUnoPictureBox.Location = new System.Drawing.Point(108, 144);
            this.filaUnoPictureBox.Name = "filaUnoPictureBox";
            this.filaUnoPictureBox.Size = new System.Drawing.Size(85, 54);
            this.filaUnoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.filaUnoPictureBox.TabIndex = 14;
            this.filaUnoPictureBox.TabStop = false;
            // 
            // atendidoPictureBox
            // 
            this.atendidoPictureBox.Location = new System.Drawing.Point(15, 144);
            this.atendidoPictureBox.Name = "atendidoPictureBox";
            this.atendidoPictureBox.Size = new System.Drawing.Size(85, 54);
            this.atendidoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.atendidoPictureBox.TabIndex = 13;
            this.atendidoPictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tiempo transcurrido: ";
            // 
            // RojoButton
            // 
            this.RojoButton.BackColor = System.Drawing.Color.Red;
            this.RojoButton.Location = new System.Drawing.Point(207, 81);
            this.RojoButton.Name = "RojoButton";
            this.RojoButton.Size = new System.Drawing.Size(81, 38);
            this.RojoButton.TabIndex = 11;
            this.RojoButton.UseVisualStyleBackColor = false;
            this.RojoButton.Click += new System.EventHandler(this.RojoButton_Click_1);
            // 
            // RosaButton
            // 
            this.RosaButton.BackColor = System.Drawing.Color.HotPink;
            this.RosaButton.Location = new System.Drawing.Point(312, 81);
            this.RosaButton.Name = "RosaButton";
            this.RosaButton.Size = new System.Drawing.Size(81, 38);
            this.RosaButton.TabIndex = 10;
            this.RosaButton.UseVisualStyleBackColor = false;
            this.RosaButton.Click += new System.EventHandler(this.RosaButton_Click_1);
            // 
            // VerdeButton
            // 
            this.VerdeButton.BackColor = System.Drawing.Color.Lime;
            this.VerdeButton.Location = new System.Drawing.Point(418, 81);
            this.VerdeButton.Name = "VerdeButton";
            this.VerdeButton.Size = new System.Drawing.Size(81, 38);
            this.VerdeButton.TabIndex = 9;
            this.VerdeButton.UseVisualStyleBackColor = false;
            this.VerdeButton.Click += new System.EventHandler(this.VerdeButton_Click_1);
            // 
            // NegroButton
            // 
            this.NegroButton.BackColor = System.Drawing.Color.Black;
            this.NegroButton.Location = new System.Drawing.Point(100, 81);
            this.NegroButton.Name = "NegroButton";
            this.NegroButton.Size = new System.Drawing.Size(81, 38);
            this.NegroButton.TabIndex = 8;
            this.NegroButton.UseVisualStyleBackColor = false;
            this.NegroButton.Click += new System.EventHandler(this.NegroButton_Click_1);
            // 
            // AzulButton
            // 
            this.AzulButton.BackColor = System.Drawing.Color.Blue;
            this.AzulButton.Location = new System.Drawing.Point(207, 19);
            this.AzulButton.Name = "AzulButton";
            this.AzulButton.Size = new System.Drawing.Size(81, 38);
            this.AzulButton.TabIndex = 7;
            this.AzulButton.UseVisualStyleBackColor = false;
            this.AzulButton.Click += new System.EventHandler(this.AzulButton_Click_1);
            // 
            // MoradoButton
            // 
            this.MoradoButton.BackColor = System.Drawing.Color.Purple;
            this.MoradoButton.Location = new System.Drawing.Point(312, 19);
            this.MoradoButton.Name = "MoradoButton";
            this.MoradoButton.Size = new System.Drawing.Size(81, 38);
            this.MoradoButton.TabIndex = 6;
            this.MoradoButton.UseVisualStyleBackColor = false;
            this.MoradoButton.Click += new System.EventHandler(this.MoradoButton_Click_1);
            // 
            // NaranjaButton
            // 
            this.NaranjaButton.BackColor = System.Drawing.Color.DarkOrange;
            this.NaranjaButton.Location = new System.Drawing.Point(418, 19);
            this.NaranjaButton.Name = "NaranjaButton";
            this.NaranjaButton.Size = new System.Drawing.Size(81, 38);
            this.NaranjaButton.TabIndex = 5;
            this.NaranjaButton.UseVisualStyleBackColor = false;
            this.NaranjaButton.Click += new System.EventHandler(this.NaranjaButton_Click_1);
            // 
            // timerJuego
            // 
            this.timerJuego.Interval = 1000;
            this.timerJuego.Tick += new System.EventHandler(this.timerJuego_Tick_1);
            // 
            // timerInsertCar
            // 
            this.timerInsertCar.Interval = 1000;
            this.timerInsertCar.Tick += new System.EventHandler(this.timerInsertCar_Tick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(284, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Práctica11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iniciarJuegoButton);
            this.Controls.Add(this.label1);
            this.Name = "Práctica11";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filaCincoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fila4PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filaTresPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filaDosPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filaUnoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.atendidoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Button iniciarJuegoButton;
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
        private Button button1;
    }
}