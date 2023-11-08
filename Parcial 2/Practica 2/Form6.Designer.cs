namespace Practica_2
{
    partial class Form6
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
            label1 = new Label();
            textBox1 = new TextBox();
            menuStrip2 = new MenuStrip();
            elijaLaOpciónToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            numsAleatoriosToolStripMenuItem = new ToolStripMenuItem();
            alumnosAproReprToolStripMenuItem = new ToolStripMenuItem();
            ordenProductToolStripMenuItem = new ToolStripMenuItem();
            organizarPalabrasToolStripMenuItem = new ToolStripMenuItem();
            invertirToolStripMenuItem = new ToolStripMenuItem();
            palindromoToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Unispace", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(151, 18);
            label1.Name = "label1";
            label1.Size = new Size(269, 18);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la palabra a revertir";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Poor Richard", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(206, 51);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 22);
            textBox1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { elijaLaOpciónToolStripMenuItem, productosToolStripMenuItem, numsAleatoriosToolStripMenuItem, alumnosAproReprToolStripMenuItem, ordenProductToolStripMenuItem, organizarPalabrasToolStripMenuItem, invertirToolStripMenuItem, palindromoToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(123, 229);
            menuStrip2.TabIndex = 7;
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
            // 
            // palindromoToolStripMenuItem
            // 
            palindromoToolStripMenuItem.Name = "palindromoToolStripMenuItem";
            palindromoToolStripMenuItem.Size = new Size(110, 19);
            palindromoToolStripMenuItem.Text = "Palindromo";
            palindromoToolStripMenuItem.Click += palindromoToolStripMenuItem_Click;
            // 
            // button1
            // 
            button1.Location = new Point(247, 88);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Revertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(151, 130);
            label2.Name = "label2";
            label2.Size = new Size(115, 19);
            label2.TabIndex = 9;
            label2.Text = "Palabra revertida:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.Font = new Font("MV Boli", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(263, 127);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(148, 28);
            textBox2.TabIndex = 10;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 229);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(menuStrip2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form6";
            Text = "Form6";
            FormClosed += Form6_FormClosed;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem elijaLaOpciónToolStripMenuItem;
        private ToolStripMenuItem productosToolStripMenuItem;
        private ToolStripMenuItem numsAleatoriosToolStripMenuItem;
        private ToolStripMenuItem alumnosAproReprToolStripMenuItem;
        private ToolStripMenuItem ordenProductToolStripMenuItem;
        private ToolStripMenuItem organizarPalabrasToolStripMenuItem;
        private ToolStripMenuItem invertirToolStripMenuItem;
        private ToolStripMenuItem palindromoToolStripMenuItem;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
    }
}