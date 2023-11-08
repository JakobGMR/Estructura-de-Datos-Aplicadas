namespace Practica_2
{
    partial class Form7
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
            menuStrip2 = new MenuStrip();
            elijaLaOpciónToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            numsAleatoriosToolStripMenuItem = new ToolStripMenuItem();
            alumnosAproReprToolStripMenuItem = new ToolStripMenuItem();
            ordenProductToolStripMenuItem = new ToolStripMenuItem();
            organizarPalabrasToolStripMenuItem = new ToolStripMenuItem();
            invertirToolStripMenuItem = new ToolStripMenuItem();
            palindromoToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
            label3 = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { elijaLaOpciónToolStripMenuItem, productosToolStripMenuItem, numsAleatoriosToolStripMenuItem, alumnosAproReprToolStripMenuItem, ordenProductToolStripMenuItem, organizarPalabrasToolStripMenuItem, invertirToolStripMenuItem, palindromoToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(123, 183);
            menuStrip2.TabIndex = 8;
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
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 116);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(203, 112);
            button1.Name = "button1";
            button1.Size = new Size(86, 23);
            button1.TabIndex = 14;
            button1.Text = "Comprobar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poor Richard", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(162, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 22);
            textBox1.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(171, 44);
            label3.Name = "label3";
            label3.Size = new Size(143, 18);
            label3.TabIndex = 11;
            label3.Text = "¿Es palindromo?";
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 183);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(menuStrip2);
            Name = "Form7";
            Text = "Form7";
            FormClosed += Form7_FormClosed;
            Load += Form7_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip2;
        private ToolStripMenuItem elijaLaOpciónToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem numsAleatoriosToolStripMenuItem;
        private ToolStripMenuItem alumnosAproReprToolStripMenuItem;
        private ToolStripMenuItem ordenProductToolStripMenuItem;
        private ToolStripMenuItem organizarPalabrasToolStripMenuItem;
        private ToolStripMenuItem invertirToolStripMenuItem;
        private ToolStripMenuItem palindromoToolStripMenuItem;
        private Label label1;
        private Button button1;
        private TextBox textBox1;
        private Label label3;
    }
}