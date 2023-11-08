namespace Pratica11_12_13
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
            panel1 = new Panel();
            btUno = new Button();
            listBox1 = new ListBox();
            rb1 = new RadioButton();
            panel2 = new Panel();
            btnDos = new Button();
            listBox2 = new ListBox();
            rb2 = new RadioButton();
            panel3 = new Panel();
            btnTres = new Button();
            listBox3 = new ListBox();
            rb3 = new RadioButton();
            radioButton1 = new RadioButton();
            FilasIn = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            ColumnasIn = new NumericUpDown();
            Generar = new Button();
            listBox4 = new ListBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FilasIn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ColumnasIn).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btUno);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(25, 65);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(564, 369);
            panel1.TabIndex = 0;
            // 
            // btUno
            // 
            btUno.BackColor = SystemColors.MenuHighlight;
            btUno.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btUno.ForeColor = SystemColors.ControlLightLight;
            btUno.Location = new Point(206, 304);
            btUno.Margin = new Padding(3, 2, 3, 2);
            btUno.Name = "btUno";
            btUno.Size = new Size(174, 34);
            btUno.TabIndex = 1;
            btUno.Text = "Generar";
            btUno.UseVisualStyleBackColor = false;
            btUno.Click += btUno_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(0, 14);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(554, 244);
            listBox1.TabIndex = 0;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(117, 35);
            rb1.Margin = new Padding(3, 2, 3, 2);
            rb1.Name = "rb1";
            rb1.Size = new Size(97, 19);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "Cuadro 10 x 5";
            rb1.UseVisualStyleBackColor = true;
            rb1.CheckedChanged += rb1_CheckedChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDos);
            panel2.Controls.Add(listBox2);
            panel2.Location = new Point(649, 74);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 360);
            panel2.TabIndex = 2;
            // 
            // btnDos
            // 
            btnDos.BackColor = SystemColors.MenuHighlight;
            btnDos.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnDos.ForeColor = SystemColors.ControlLightLight;
            btnDos.Location = new Point(79, 313);
            btnDos.Margin = new Padding(3, 2, 3, 2);
            btnDos.Name = "btnDos";
            btnDos.Size = new Size(191, 33);
            btnDos.TabIndex = 1;
            btnDos.Text = "Generar";
            btnDos.UseVisualStyleBackColor = false;
            btnDos.Click += btnDos_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(16, 13);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(381, 214);
            listBox2.TabIndex = 0;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(713, 35);
            rb2.Margin = new Padding(3, 2, 3, 2);
            rb2.Name = "rb2";
            rb2.Size = new Size(59, 19);
            rb2.TabIndex = 3;
            rb2.TabStop = true;
            rb2.Text = "Ventas";
            rb2.UseVisualStyleBackColor = true;
            rb2.CheckedChanged += rb2_CheckedChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnTres);
            panel3.Controls.Add(listBox3);
            panel3.Location = new Point(1070, 74);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(278, 364);
            panel3.TabIndex = 4;
            // 
            // btnTres
            // 
            btnTres.BackColor = SystemColors.MenuHighlight;
            btnTres.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTres.ForeColor = SystemColors.ControlLightLight;
            btnTres.Location = new Point(60, 313);
            btnTres.Margin = new Padding(3, 2, 3, 2);
            btnTres.Name = "btnTres";
            btnTres.Size = new Size(186, 26);
            btnTres.TabIndex = 1;
            btnTres.Text = "Generar";
            btnTres.UseVisualStyleBackColor = false;
            btnTres.Click += btnTres_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(30, 31);
            listBox3.Margin = new Padding(3, 2, 3, 2);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(235, 229);
            listBox3.TabIndex = 0;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(1092, 35);
            rb3.Margin = new Padding(3, 2, 3, 2);
            rb3.Name = "rb3";
            rb3.Size = new Size(98, 19);
            rb3.TabIndex = 5;
            rb3.TabStop = true;
            rb3.Text = "Calificaciones";
            rb3.UseVisualStyleBackColor = true;
            rb3.CheckedChanged += rb3_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(199, 458);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cuadro Magico";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // FilasIn
            // 
            FilasIn.Location = new Point(66, 527);
            FilasIn.Name = "FilasIn";
            FilasIn.Size = new Size(120, 23);
            FilasIn.TabIndex = 7;
            FilasIn.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 497);
            label1.Name = "label1";
            label1.Size = new Size(139, 15);
            label1.TabIndex = 8;
            label1.Text = "Inserte el número de filas";
            label1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(266, 497);
            label2.Name = "label2";
            label2.Size = new Size(170, 15);
            label2.TabIndex = 10;
            label2.Text = "Inserte el número de columnas";
            label2.Visible = false;
            // 
            // ColumnasIn
            // 
            ColumnasIn.Location = new Point(275, 527);
            ColumnasIn.Name = "ColumnasIn";
            ColumnasIn.Size = new Size(120, 23);
            ColumnasIn.TabIndex = 9;
            ColumnasIn.Visible = false;
            ColumnasIn.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // Generar
            // 
            Generar.Location = new Point(199, 566);
            Generar.Name = "Generar";
            Generar.Size = new Size(75, 23);
            Generar.TabIndex = 11;
            Generar.Text = "Generar";
            Generar.UseVisualStyleBackColor = true;
            Generar.Visible = false;
            Generar.Click += Generar_Click;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.ItemHeight = 15;
            listBox4.Location = new Point(152, 601);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(166, 124);
            listBox4.TabIndex = 17;
            listBox4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 737);
            Controls.Add(listBox4);
            Controls.Add(Generar);
            Controls.Add(label2);
            Controls.Add(ColumnasIn);
            Controls.Add(label1);
            Controls.Add(FilasIn);
            Controls.Add(radioButton1);
            Controls.Add(rb3);
            Controls.Add(panel3);
            Controls.Add(rb2);
            Controls.Add(panel2);
            Controls.Add(rb1);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)FilasIn).EndInit();
            ((System.ComponentModel.ISupportInitialize)ColumnasIn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ListBox listBox1;
        private RadioButton rb1;
        private Button btUno;
        private Panel panel2;
        private ListBox listBox2;
        private RadioButton rb2;
        private Button btnDos;
        private Panel panel3;
        private ListBox listBox3;
        private RadioButton rb3;
        private Button btnTres;
        private RadioButton radioButton1;
        private NumericUpDown FilasIn;
        private Label label1;
        private Label label2;
        private NumericUpDown ColumnasIn;
        private Button Generar;
        private ListBox listBox4;
    }
}