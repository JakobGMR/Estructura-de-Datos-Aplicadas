namespace Practica_2
{
    partial class Form2
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
            generarButton = new Button();
            listBox1 = new ListBox();
            paresListBox = new ListBox();
            inparesListBox = new ListBox();
            label2 = new Label();
            label3 = new Label();
            menuStrip2 = new MenuStrip();
            elijaLaOpciónToolStripMenuItem = new ToolStripMenuItem();
            productosToolStripMenuItem = new ToolStripMenuItem();
            numsAleatoriosToolStripMenuItem = new ToolStripMenuItem();
            alumnosAproReprToolStripMenuItem = new ToolStripMenuItem();
            ordenProductToolStripMenuItem = new ToolStripMenuItem();
            organizarPalabrasToolStripMenuItem = new ToolStripMenuItem();
            invertirToolStripMenuItem = new ToolStripMenuItem();
            palindromoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 21);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 8;
            label1.Text = "Generar";
            // 
            // generarButton
            // 
            generarButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            generarButton.Location = new Point(270, 54);
            generarButton.Name = "generarButton";
            generarButton.Size = new Size(94, 32);
            generarButton.TabIndex = 9;
            generarButton.Text = "Generar";
            generarButton.UseVisualStyleBackColor = true;
            generarButton.Click += generarButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(147, 92);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(381, 94);
            listBox1.TabIndex = 10;
            listBox1.Visible = false;
            // 
            // paresListBox
            // 
            paresListBox.BackColor = SystemColors.GradientInactiveCaption;
            paresListBox.FormattingEnabled = true;
            paresListBox.ItemHeight = 15;
            paresListBox.Location = new Point(147, 211);
            paresListBox.Name = "paresListBox";
            paresListBox.Size = new Size(186, 94);
            paresListBox.TabIndex = 11;
            paresListBox.Visible = false;
            // 
            // inparesListBox
            // 
            inparesListBox.BackColor = SystemColors.ScrollBar;
            inparesListBox.FormattingEnabled = true;
            inparesListBox.ItemHeight = 15;
            inparesListBox.Location = new Point(350, 211);
            inparesListBox.Name = "inparesListBox";
            inparesListBox.Size = new Size(178, 94);
            inparesListBox.TabIndex = 12;
            inparesListBox.Visible = false;
            inparesListBox.SelectedIndexChanged += inparesListBox_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(218, 193);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 13;
            label2.Text = "Pares";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(413, 193);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 14;
            label3.Text = "Inpares";
            // 
            // menuStrip2
            // 
            menuStrip2.Dock = DockStyle.Left;
            menuStrip2.Items.AddRange(new ToolStripItem[] { elijaLaOpciónToolStripMenuItem, productosToolStripMenuItem, numsAleatoriosToolStripMenuItem, alumnosAproReprToolStripMenuItem, ordenProductToolStripMenuItem, organizarPalabrasToolStripMenuItem, invertirToolStripMenuItem, palindromoToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(126, 335);
            menuStrip2.TabIndex = 15;
            menuStrip2.Text = "menuStrip2";
            // 
            // elijaLaOpciónToolStripMenuItem
            // 
            elijaLaOpciónToolStripMenuItem.Enabled = false;
            elijaLaOpciónToolStripMenuItem.Name = "elijaLaOpciónToolStripMenuItem";
            elijaLaOpciónToolStripMenuItem.Size = new Size(113, 19);
            elijaLaOpciónToolStripMenuItem.Text = "Elija la opción";
            // 
            // productosToolStripMenuItem
            // 
            productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            productosToolStripMenuItem.Size = new Size(113, 19);
            productosToolStripMenuItem.Text = "Productos";
            productosToolStripMenuItem.Click += productosToolStripMenuItem_Click_1;
            // 
            // numsAleatoriosToolStripMenuItem
            // 
            numsAleatoriosToolStripMenuItem.Name = "numsAleatoriosToolStripMenuItem";
            numsAleatoriosToolStripMenuItem.Size = new Size(113, 19);
            numsAleatoriosToolStripMenuItem.Text = "Nums Aleatorios";
            // 
            // alumnosAproReprToolStripMenuItem
            // 
            alumnosAproReprToolStripMenuItem.Name = "alumnosAproReprToolStripMenuItem";
            alumnosAproReprToolStripMenuItem.Size = new Size(113, 19);
            alumnosAproReprToolStripMenuItem.Text = "AlumnosAproRepr";
            alumnosAproReprToolStripMenuItem.Click += alumnosAproReprToolStripMenuItem_Click_1;
            // 
            // ordenProductToolStripMenuItem
            // 
            ordenProductToolStripMenuItem.Name = "ordenProductToolStripMenuItem";
            ordenProductToolStripMenuItem.Size = new Size(113, 19);
            ordenProductToolStripMenuItem.Text = "OrdenProduct";
            ordenProductToolStripMenuItem.Click += ordenProductToolStripMenuItem_Click;
            // 
            // organizarPalabrasToolStripMenuItem
            // 
            organizarPalabrasToolStripMenuItem.Name = "organizarPalabrasToolStripMenuItem";
            organizarPalabrasToolStripMenuItem.Size = new Size(113, 19);
            organizarPalabrasToolStripMenuItem.Text = "Organizar Palabras";
            organizarPalabrasToolStripMenuItem.Click += organizarPalabrasToolStripMenuItem_Click;
            // 
            // invertirToolStripMenuItem
            // 
            invertirToolStripMenuItem.Name = "invertirToolStripMenuItem";
            invertirToolStripMenuItem.Size = new Size(113, 19);
            invertirToolStripMenuItem.Text = "Invertir";
            invertirToolStripMenuItem.Click += invertirToolStripMenuItem_Click;
            // 
            // palindromoToolStripMenuItem
            // 
            palindromoToolStripMenuItem.Name = "palindromoToolStripMenuItem";
            palindromoToolStripMenuItem.Size = new Size(113, 19);
            palindromoToolStripMenuItem.Text = "Palindromo";
            palindromoToolStripMenuItem.Click += palindromoToolStripMenuItem_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 335);
            Controls.Add(menuStrip2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(inparesListBox);
            Controls.Add(paresListBox);
            Controls.Add(listBox1);
            Controls.Add(generarButton);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            FormClosed += Form2_FormClosed;
            Load += Form2_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button generarButton;
        private ListBox listBox1;
        private ListBox paresListBox;
        private ListBox inparesListBox;
        private Label label2;
        private Label label3;
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