namespace WinFormsApp1
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
            Circulo = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            labelCircArea = new Label();
            labelCircPeri = new Label();
            btnAreaCirc = new Button();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            labelRecArea = new Label();
            labelRecPeri = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            button5 = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            panel3 = new Panel();
            labelTriaArea = new Label();
            labelTriaPeri = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            button6 = new Button();
            label9 = new Label();
            label10 = new Label();
            textBox4 = new TextBox();
            label11 = new Label();
            panel4 = new Panel();
            labelCuaArea = new Label();
            labelCuaPeri = new Label();
            button7 = new Button();
            label13 = new Label();
            label14 = new Label();
            textBox6 = new TextBox();
            label15 = new Label();
            errorProvider1 = new ErrorProvider(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // Circulo
            // 
            Circulo.Location = new Point(55, 27);
            Circulo.Name = "Circulo";
            Circulo.Size = new Size(75, 23);
            Circulo.TabIndex = 0;
            Circulo.Text = "Circulo";
            Circulo.UseVisualStyleBackColor = true;
            Circulo.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(255, 27);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Rectangulo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(447, 27);
            button3.Name = "button3";
            button3.Size = new Size(130, 23);
            button3.TabIndex = 2;
            button3.Text = "Triangulo Equilatero";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(661, 27);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Cuadrado";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelCircArea);
            panel1.Controls.Add(labelCircPeri);
            panel1.Controls.Add(btnAreaCirc);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(156, 181);
            panel1.TabIndex = 4;
            // 
            // labelCircArea
            // 
            labelCircArea.AutoSize = true;
            labelCircArea.Location = new Point(91, 104);
            labelCircArea.Name = "labelCircArea";
            labelCircArea.Size = new Size(44, 15);
            labelCircArea.TabIndex = 6;
            labelCircArea.Text = "label16";
            // 
            // labelCircPeri
            // 
            labelCircPeri.AutoSize = true;
            labelCircPeri.Location = new Point(91, 69);
            labelCircPeri.Name = "labelCircPeri";
            labelCircPeri.Size = new Size(44, 15);
            labelCircPeri.TabIndex = 5;
            labelCircPeri.Text = "label12";
            // 
            // btnAreaCirc
            // 
            btnAreaCirc.Location = new Point(43, 133);
            btnAreaCirc.Name = "btnAreaCirc";
            btnAreaCirc.Size = new Size(75, 23);
            btnAreaCirc.TabIndex = 4;
            btnAreaCirc.Text = "Circulo";
            btnAreaCirc.UseVisualStyleBackColor = true;
            btnAreaCirc.Click += btnAreaCirc_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 104);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Area";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 69);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 2;
            label2.Text = "Perimetro";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(13, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(131, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "Radio";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.GradientInactiveCaption;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(labelRecArea);
            panel2.Controls.Add(labelRecPeri);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(label6);
            panel2.Location = new Point(212, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(156, 181);
            panel2.TabIndex = 5;
            // 
            // labelRecArea
            // 
            labelRecArea.AutoSize = true;
            labelRecArea.Location = new Point(94, 104);
            labelRecArea.Name = "labelRecArea";
            labelRecArea.Size = new Size(44, 15);
            labelRecArea.TabIndex = 8;
            labelRecArea.Text = "label12";
            // 
            // labelRecPeri
            // 
            labelRecPeri.AutoSize = true;
            labelRecPeri.Location = new Point(94, 69);
            labelRecPeri.Name = "labelRecPeri";
            labelRecPeri.Size = new Size(44, 15);
            labelRecPeri.TabIndex = 7;
            labelRecPeri.Text = "label12";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(86, 30);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(63, 23);
            textBox3.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(99, 12);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 5;
            label7.Text = "Altura";
            // 
            // button5
            // 
            button5.Location = new Point(43, 133);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Rectangulo";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 104);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 3;
            label4.Text = "Area";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 69);
            label5.Name = "label5";
            label5.Size = new Size(59, 15);
            label5.TabIndex = 2;
            label5.Text = "Perimetro";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(13, 30);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(63, 23);
            textBox2.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 12);
            label6.Name = "label6";
            label6.Size = new Size(31, 15);
            label6.TabIndex = 0;
            label6.Text = "Base";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.GradientInactiveCaption;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(labelTriaArea);
            panel3.Controls.Add(labelTriaPeri);
            panel3.Controls.Add(textBox5);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(button6);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(textBox4);
            panel3.Controls.Add(label11);
            panel3.Location = new Point(430, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(156, 181);
            panel3.TabIndex = 7;
            // 
            // labelTriaArea
            // 
            labelTriaArea.AutoSize = true;
            labelTriaArea.Location = new Point(94, 104);
            labelTriaArea.Name = "labelTriaArea";
            labelTriaArea.Size = new Size(44, 15);
            labelTriaArea.TabIndex = 10;
            labelTriaArea.Text = "label12";
            // 
            // labelTriaPeri
            // 
            labelTriaPeri.AutoSize = true;
            labelTriaPeri.Location = new Point(94, 69);
            labelTriaPeri.Name = "labelTriaPeri";
            labelTriaPeri.Size = new Size(44, 15);
            labelTriaPeri.TabIndex = 9;
            labelTriaPeri.Text = "label12";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(86, 30);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(63, 23);
            textBox5.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(99, 12);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 5;
            label8.Text = "Altura";
            // 
            // button6
            // 
            button6.Location = new Point(43, 133);
            button6.Name = "button6";
            button6.Size = new Size(75, 23);
            button6.TabIndex = 4;
            button6.Text = "Triangulo";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 104);
            label9.Name = "label9";
            label9.Size = new Size(31, 15);
            label9.TabIndex = 3;
            label9.Text = "Area";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(17, 69);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 2;
            label10.Text = "Perimetro";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(13, 30);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(63, 23);
            textBox4.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 12);
            label11.Name = "label11";
            label11.Size = new Size(31, 15);
            label11.TabIndex = 0;
            label11.Text = "Base";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.GradientInactiveCaption;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(labelCuaArea);
            panel4.Controls.Add(labelCuaPeri);
            panel4.Controls.Add(button7);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(textBox6);
            panel4.Controls.Add(label15);
            panel4.Location = new Point(621, 73);
            panel4.Name = "panel4";
            panel4.Size = new Size(156, 181);
            panel4.TabIndex = 8;
            // 
            // labelCuaArea
            // 
            labelCuaArea.AutoSize = true;
            labelCuaArea.Location = new Point(94, 104);
            labelCuaArea.Name = "labelCuaArea";
            labelCuaArea.Size = new Size(44, 15);
            labelCuaArea.TabIndex = 12;
            labelCuaArea.Text = "label12";
            // 
            // labelCuaPeri
            // 
            labelCuaPeri.AutoSize = true;
            labelCuaPeri.Location = new Point(94, 69);
            labelCuaPeri.Name = "labelCuaPeri";
            labelCuaPeri.Size = new Size(44, 15);
            labelCuaPeri.TabIndex = 11;
            labelCuaPeri.Text = "label12";
            // 
            // button7
            // 
            button7.Location = new Point(43, 133);
            button7.Name = "button7";
            button7.Size = new Size(75, 23);
            button7.TabIndex = 4;
            button7.Text = "Cuadrado";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(30, 104);
            label13.Name = "label13";
            label13.Size = new Size(31, 15);
            label13.TabIndex = 3;
            label13.Text = "Area";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 69);
            label14.Name = "label14";
            label14.Size = new Size(59, 15);
            label14.TabIndex = 2;
            label14.Text = "Perimetro";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(13, 30);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(125, 23);
            textBox6.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(60, 12);
            label15.Name = "label15";
            label15.Size = new Size(33, 15);
            label15.TabIndex = 0;
            label15.Text = "Lado";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(800, 304);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Circulo);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Circulo;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label1;
        private Button btnAreaCirc;
        private Label label3;
        private Label label2;
        private TextBox textBox1;
        private Panel panel2;
        private TextBox textBox3;
        private Label label7;
        private Button button5;
        private Label label4;
        private Label label5;
        private TextBox textBox2;
        private Label label6;
        private Panel panel3;
        private TextBox textBox5;
        private Label label8;
        private Button button6;
        private Label label9;
        private Label label10;
        private TextBox textBox4;
        private Label label11;
        private Panel panel4;
        private Button button7;
        private Label label13;
        private Label label14;
        private TextBox textBox6;
        private Label label15;
        private Label labelCircArea;
        private Label labelCircPeri;
        private Label labelRecArea;
        private Label labelRecPeri;
        private Label labelTriaArea;
        private Label labelTriaPeri;
        private Label labelCuaArea;
        private Label labelCuaPeri;
        private ErrorProvider errorProvider1;
    }
}