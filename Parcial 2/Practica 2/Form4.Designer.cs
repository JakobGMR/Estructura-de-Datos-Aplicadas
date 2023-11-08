namespace Practica_2
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            elimButton = new Button();
            ingreNombButton = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            agregarButton = new Button();
            eliminarButton = new Button();
            compraBtn = new Button();
            listBox1 = new ListBox();
            menuStrip2 = new MenuStrip();
            elijaLaOpciónToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            numsAleatoriosToolStripMenuItem = new ToolStripMenuItem();
            alumnosAproReprToolStripMenuItem = new ToolStripMenuItem();
            ordenProductToolStripMenuItem = new ToolStripMenuItem();
            organizarPalabrasToolStripMenuItem = new ToolStripMenuItem();
            invertirToolStripMenuItem = new ToolStripMenuItem();
            palindromoToolStripMenuItem = new ToolStripMenuItem();
            panel2.SuspendLayout();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.HotPink;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(elimButton);
            panel2.Controls.Add(ingreNombButton);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(250, 55);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 137);
            panel2.TabIndex = 9;
            panel2.Visible = false;
            // 
            // elimButton
            // 
            elimButton.Location = new Point(92, 87);
            elimButton.Name = "elimButton";
            elimButton.Size = new Size(75, 23);
            elimButton.TabIndex = 11;
            elimButton.Text = "Eliminar";
            elimButton.UseVisualStyleBackColor = true;
            elimButton.Visible = false;
            elimButton.Click += elimButton_Click;
            // 
            // ingreNombButton
            // 
            ingreNombButton.Location = new Point(92, 87);
            ingreNombButton.Name = "ingreNombButton";
            ingreNombButton.Size = new Size(75, 23);
            ingreNombButton.TabIndex = 2;
            ingreNombButton.Text = "Ingresar";
            ingreNombButton.UseVisualStyleBackColor = true;
            ingreNombButton.Visible = false;
            ingreNombButton.Click += ingreNombButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(48, 43);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(168, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 15);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el nombre del producto";
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(294, 26);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(75, 23);
            agregarButton.TabIndex = 8;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // eliminarButton
            // 
            eliminarButton.Location = new Point(424, 26);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(75, 23);
            eliminarButton.TabIndex = 10;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = true;
            eliminarButton.Click += eliminarButton_Click;
            // 
            // compraBtn
            // 
            compraBtn.Location = new Point(378, 350);
            compraBtn.Name = "compraBtn";
            compraBtn.Size = new Size(75, 23);
            compraBtn.TabIndex = 11;
            compraBtn.Text = "Comprar";
            compraBtn.UseVisualStyleBackColor = true;
            compraBtn.Click += compraBtn_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(250, 197);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(289, 139);
            listBox1.TabIndex = 12;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { elijaLaOpciónToolStripMenuItem, productosToolStripMenuItem, numsAleatoriosToolStripMenuItem, alumnosAproReprToolStripMenuItem, ordenProductToolStripMenuItem, organizarPalabrasToolStripMenuItem, invertirToolStripMenuItem, palindromoToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(123, 381);
            menuStrip2.TabIndex = 17;
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
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 381);
            Controls.Add(menuStrip2);
            Controls.Add(listBox1);
            Controls.Add(compraBtn);
            Controls.Add(eliminarButton);
            Controls.Add(panel2);
            Controls.Add(agregarButton);
            Name = "Form4";
            Text = "Form4";
            FormClosed += Form4_FormClosed;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Button ingreNombButton;
        private TextBox textBox1;
        private Label label1;
        private Button agregarButton;
        private Button eliminarButton;
        private Button elimButton;
        private Button compraBtn;
        private ListBox listBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem elijaLaOpciónToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem numsAleatoriosToolStripMenuItem;
        private ToolStripMenuItem alumnosAproReprToolStripMenuItem;
        private ToolStripMenuItem ordenProductToolStripMenuItem;
        private ToolStripMenuItem organizarPalabrasToolStripMenuItem;
        private ToolStripMenuItem invertirToolStripMenuItem;
        private ToolStripMenuItem palindromoToolStripMenuItem;
    }
}