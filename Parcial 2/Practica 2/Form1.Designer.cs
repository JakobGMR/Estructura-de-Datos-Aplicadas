namespace Practica_2
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
            menuStrip2 = new MenuStrip();
            elijaLaOpciónToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            numsAleatoriosToolStripMenuItem = new ToolStripMenuItem();
            alumnosAproReprToolStripMenuItem = new ToolStripMenuItem();
            ordenProductToolStripMenuItem = new ToolStripMenuItem();
            organizarPalabrasToolStripMenuItem = new ToolStripMenuItem();
            invertirToolStripMenuItem = new ToolStripMenuItem();
            palindromoToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            panel4 = new Panel();
            listBox1 = new ListBox();
            ocultarButton = new Button();
            panel3 = new Panel();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            mostrarButton = new Button();
            button1 = new Button();
            panel2 = new Panel();
            ingreNombButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            agregarButton = new Button();
            menuStrip2.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { elijaLaOpciónToolStripMenuItem, productosToolStripMenuItem, numsAleatoriosToolStripMenuItem, alumnosAproReprToolStripMenuItem, ordenProductToolStripMenuItem, organizarPalabrasToolStripMenuItem, invertirToolStripMenuItem, palindromoToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(123, 450);
            menuStrip2.TabIndex = 6;
            menuStrip2.Text = "menuStrip2";
            // 
            // elijaLaOpciónToolStripMenuItem
            // 
            elijaLaOpciónToolStripMenuItem.Enabled = false;
            elijaLaOpciónToolStripMenuItem.Name = "elijaLaOpciónToolStripMenuItem";
            elijaLaOpciónToolStripMenuItem.Size = new Size(110, 19);
            elijaLaOpciónToolStripMenuItem.Text = "Elija la opción";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(110, 19);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click;
            // 
            // numsAleatoriosToolStripMenuItem
            // 
            numsAleatoriosToolStripMenuItem.Name = "numsAleatoriosToolStripMenuItem";
            numsAleatoriosToolStripMenuItem.Size = new Size(110, 19);
            numsAleatoriosToolStripMenuItem.Text = "Nums Aleatorios";
            numsAleatoriosToolStripMenuItem.Click += numsAleatoriosToolStripMenuItem_Click;
            // 
            // alumnosAproReprToolStripMenuItem
            // 
            alumnosAproReprToolStripMenuItem.Name = "alumnosAproReprToolStripMenuItem";
            alumnosAproReprToolStripMenuItem.Size = new Size(110, 19);
            alumnosAproReprToolStripMenuItem.Text = "AlumnosAproRepr";
            alumnosAproReprToolStripMenuItem.Click += alumnosAproReprToolStripMenuItem_Click;
            // 
            // ordenProductToolStripMenuItem
            // 
            ordenProductToolStripMenuItem.Name = "ordenProductToolStripMenuItem";
            ordenProductToolStripMenuItem.Size = new Size(110, 19);
            ordenProductToolStripMenuItem.Text = "OrdenProduct";
            ordenProductToolStripMenuItem.Click += ordenProductToolStripMenuItem_Click;
            // 
            // organizarPalabrasToolStripMenuItem
            // 
            organizarPalabrasToolStripMenuItem.Name = "organizarPalabrasToolStripMenuItem";
            organizarPalabrasToolStripMenuItem.Size = new Size(110, 19);
            organizarPalabrasToolStripMenuItem.Text = "Organizar Palabras";
            organizarPalabrasToolStripMenuItem.Click += organizarPalabrasToolStripMenuItem_Click;
            // 
            // invertirToolStripMenuItem
            // 
            invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            invertirToolStripMenuItem.Size = new Size(110, 19);
            invertirToolStripMenuItem.Text = "Invertir";
            invertirToolStripMenuItem.Click += invertirToolStripMenuItem_Click;
            // 
            // palindromoToolStripMenuItem
            // 
            palindromoToolStripMenuItem.Name = "palindromoToolStripMenuItem";
            palindromoToolStripMenuItem.Size = new Size(110, 19);
            palindromoToolStripMenuItem.Text = "Palindromo";
            palindromoToolStripMenuItem.Click += palindromoToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(mostrarButton);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(agregarButton);
            panel1.Location = new Point(101, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(666, 361);
            panel1.TabIndex = 7;
            panel1.Visible = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(listBox1);
            panel4.Controls.Add(ocultarButton);
            panel4.Location = new Point(167, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(415, 263);
            panel4.TabIndex = 5;
            panel4.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(23, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(369, 154);
            listBox1.TabIndex = 1;
            // 
            // ocultarButton
            // 
            ocultarButton.Location = new Point(171, 214);
            ocultarButton.Name = "ocultarButton";
            ocultarButton.Size = new Size(75, 23);
            ocultarButton.TabIndex = 0;
            ocultarButton.Text = "Ocultar";
            ocultarButton.UseVisualStyleBackColor = true;
            ocultarButton.Click += ocultarButton_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.DodgerBlue;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(button2);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(167, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(327, 137);
            panel3.TabIndex = 3;
            panel3.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(127, 87);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 43);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(168, 23);
            textBox2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 15);
            label2.Name = "label2";
            label2.Size = new Size(173, 15);
            label2.TabIndex = 0;
            label2.Text = "Ingrese el nombre del producto";
            // 
            // mostrarButton
            // 
            mostrarButton.Location = new Point(18, 245);
            mostrarButton.Name = "mostrarButton";
            mostrarButton.Size = new Size(123, 23);
            mostrarButton.TabIndex = 4;
            mostrarButton.Text = "Mostrar productos";
            mostrarButton.UseVisualStyleBackColor = true;
            mostrarButton.Click += mostrarButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 85);
            button1.Name = "button1";
            button1.Size = new Size(117, 23);
            button1.TabIndex = 3;
            button1.Text = "Eliminar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MediumOrchid;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ingreNombButton);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(167, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(327, 137);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // ingreNombButton
            // 
            ingreNombButton.Location = new Point(127, 87);
            ingreNombButton.Name = "ingreNombButton";
            ingreNombButton.Size = new Size(75, 23);
            ingreNombButton.TabIndex = 2;
            ingreNombButton.Text = "Ingresar";
            ingreNombButton.UseVisualStyleBackColor = true;
            ingreNombButton.Click += ingreNombButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 15);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el nombre del producto";
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(290, 12);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 0;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(menuStrip2);
            Name = "Form1";
            Text = "Form1";
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem elijaLaOpciónToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private Panel panel1;
        private Button agregarButton;
        private Panel panel2;
        private Button ingreNombButton;
        private TextBox textBox1;
        private Label label1;
        private Panel panel3;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button mostrarButton;
        private Panel panel4;
        private ListBox listBox1;
        private Button ocultarButton;
        private ToolStripMenuItem numsAleatoriosToolStripMenuItem;
        private ToolStripMenuItem alumnosAproReprToolStripMenuItem;
        private ToolStripMenuItem ordenProductToolStripMenuItem;
        private ToolStripMenuItem organizarPalabrasToolStripMenuItem;
        private ToolStripMenuItem invertirToolStripMenuItem;
        private ToolStripMenuItem palindromoToolStripMenuItem;
    }
}