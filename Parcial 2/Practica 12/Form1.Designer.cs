namespace Practica_12
{
    partial class Form1
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
            btnEntradaAuto = new Button();
            btnSalidaAuto = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPlacas = new TextBox();
            txtPropietario = new TextBox();
            SuspendLayout();
            // 
            // btnEntradaAuto
            // 
            btnEntradaAuto.Location = new Point(31, 128);
            btnEntradaAuto.Margin = new Padding(2);
            btnEntradaAuto.Name = "btnEntradaAuto";
            btnEntradaAuto.Size = new Size(89, 39);
            btnEntradaAuto.TabIndex = 0;
            btnEntradaAuto.Text = "Registrar Entrada";
            btnEntradaAuto.UseVisualStyleBackColor = true;
            btnEntradaAuto.Click += btnEntradaAuto_Click;
            // 
            // btnSalidaAuto
            // 
            btnSalidaAuto.Location = new Point(134, 128);
            btnSalidaAuto.Margin = new Padding(2);
            btnSalidaAuto.Name = "btnSalidaAuto";
            btnSalidaAuto.Size = new Size(89, 39);
            btnSalidaAuto.TabIndex = 1;
            btnSalidaAuto.Text = "Registrar Salida";
            btnSalidaAuto.UseVisualStyleBackColor = true;
            btnSalidaAuto.Click += btnSalidaAuto_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 28);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Placas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 69);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 3;
            label2.Text = "Propietario";
            // 
            // txtPlacas
            // 
            txtPlacas.Location = new Point(117, 24);
            txtPlacas.Margin = new Padding(2);
            txtPlacas.Name = "txtPlacas";
            txtPlacas.Size = new Size(106, 23);
            txtPlacas.TabIndex = 4;
            // 
            // txtPropietario
            // 
            txtPropietario.Location = new Point(117, 67);
            txtPropietario.Margin = new Padding(2);
            txtPropietario.Name = "txtPropietario";
            txtPropietario.Size = new Size(106, 23);
            txtPropietario.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(248, 186);
            Controls.Add(txtPropietario);
            Controls.Add(txtPlacas);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSalidaAuto);
            Controls.Add(btnEntradaAuto);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Práctica12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEntradaAuto;
        private Button btnSalidaAuto;
        private Label label1;
        private Label label2;
        private TextBox txtPlacas;
        private TextBox txtPropietario;
    }
}
