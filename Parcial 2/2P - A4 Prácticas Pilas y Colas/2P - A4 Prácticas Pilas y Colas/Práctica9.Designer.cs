namespace _2P___A4_Prácticas_Pilas_y_Colas
{
    partial class Práctica9
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
            this.listBoxPila = new System.Windows.Forms.ListBox();
            this.textBoxNuevo = new System.Windows.Forms.TextBox();
            this.textBoxViejo = new System.Windows.Forms.TextBox();
            this.buttonReemplazar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxPila
            // 
            this.listBoxPila.FormattingEnabled = true;
            this.listBoxPila.Location = new System.Drawing.Point(250, 95);
            this.listBoxPila.Name = "listBoxPila";
            this.listBoxPila.Size = new System.Drawing.Size(238, 277);
            this.listBoxPila.TabIndex = 0;
            // 
            // textBoxNuevo
            // 
            this.textBoxNuevo.Location = new System.Drawing.Point(248, 38);
            this.textBoxNuevo.Name = "textBoxNuevo";
            this.textBoxNuevo.Size = new System.Drawing.Size(100, 20);
            this.textBoxNuevo.TabIndex = 1;
            this.textBoxNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNuevo_KeyPress);
            this.textBoxNuevo.Leave += new System.EventHandler(this.textBoxNuevo_Leave);
            // 
            // textBoxViejo
            // 
            this.textBoxViejo.Location = new System.Drawing.Point(410, 38);
            this.textBoxViejo.Name = "textBoxViejo";
            this.textBoxViejo.Size = new System.Drawing.Size(100, 20);
            this.textBoxViejo.TabIndex = 2;
            this.textBoxViejo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxViejo_KeyPress);
            this.textBoxViejo.Leave += new System.EventHandler(this.textBoxViejo_Leave);
            // 
            // buttonReemplazar
            // 
            this.buttonReemplazar.Location = new System.Drawing.Point(64, 95);
            this.buttonReemplazar.Name = "buttonReemplazar";
            this.buttonReemplazar.Size = new System.Drawing.Size(75, 23);
            this.buttonReemplazar.TabIndex = 3;
            this.buttonReemplazar.Text = "Reemplazar";
            this.buttonReemplazar.UseVisualStyleBackColor = true;
            this.buttonReemplazar.Click += new System.EventHandler(this.buttonReemplazar_Click_1);
            // 
            // Nuevo
            // 
            this.Nuevo.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Nuevo.AutoSize = true;
            this.Nuevo.Location = new System.Drawing.Point(198, 38);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(39, 13);
            this.Nuevo.TabIndex = 4;
            this.Nuevo.Text = "Nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(366, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Viejo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Práctica9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.buttonReemplazar);
            this.Controls.Add(this.textBoxViejo);
            this.Controls.Add(this.textBoxNuevo);
            this.Controls.Add(this.listBoxPila);
            this.Name = "Práctica9";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxPila;
        private System.Windows.Forms.TextBox textBoxNuevo;
        private System.Windows.Forms.TextBox textBoxViejo;
        private System.Windows.Forms.Button buttonReemplazar;
        private System.Windows.Forms.Label Nuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}