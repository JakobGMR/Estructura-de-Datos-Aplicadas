namespace _2P___A4_Prácticas_Pilas_y_Colas
{
    partial class Práctica12
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpie los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEntradaAuto = new System.Windows.Forms.Button();
            this.btnSalidaAuto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntradaAuto
            // 
            this.btnEntradaAuto.Location = new System.Drawing.Point(27, 111);
            this.btnEntradaAuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEntradaAuto.Name = "btnEntradaAuto";
            this.btnEntradaAuto.Size = new System.Drawing.Size(76, 34);
            this.btnEntradaAuto.TabIndex = 0;
            this.btnEntradaAuto.Text = "Registrar Entrada";
            this.btnEntradaAuto.UseVisualStyleBackColor = true;
            this.btnEntradaAuto.Click += new System.EventHandler(this.btnEntradaAuto_Click);
            // 
            // btnSalidaAuto
            // 
            this.btnSalidaAuto.Location = new System.Drawing.Point(115, 111);
            this.btnSalidaAuto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalidaAuto.Name = "btnSalidaAuto";
            this.btnSalidaAuto.Size = new System.Drawing.Size(76, 34);
            this.btnSalidaAuto.TabIndex = 1;
            this.btnSalidaAuto.Text = "Registrar Salida";
            this.btnSalidaAuto.UseVisualStyleBackColor = true;
            this.btnSalidaAuto.Click += new System.EventHandler(this.btnSalidaAuto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Placas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Propietario";
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(100, 21);
            this.txtPlacas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(91, 20);
            this.txtPlacas.TabIndex = 4;
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(100, 58);
            this.txtPropietario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(91, 20);
            this.txtPropietario.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Práctica12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 206);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtPropietario);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalidaAuto);
            this.Controls.Add(this.btnEntradaAuto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Práctica12";
            this.Text = "Práctica12";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntradaAuto;
        private System.Windows.Forms.Button btnSalidaAuto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.Button button1;
    }
}
