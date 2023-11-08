using System.Drawing;
using System.Windows.Forms;

namespace _2P___A4_Prácticas_Pilas_y_Colas
{
    partial class Práctica10
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
            this.DatosClientepanel = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nombreClientetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NumTurnotextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.agregarButton = new System.Windows.Forms.Button();
            this.atenderButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.turnoActualLabel = new System.Windows.Forms.Label();
            this.turnoAtendidoLabel = new System.Windows.Forms.Label();
            this.DatosClientepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DatosClientepanel
            // 
            this.DatosClientepanel.BackColor = System.Drawing.Color.Plum;
            this.DatosClientepanel.Controls.Add(this.comboBox1);
            this.DatosClientepanel.Controls.Add(this.nombreClientetextBox);
            this.DatosClientepanel.Controls.Add(this.label3);
            this.DatosClientepanel.Controls.Add(this.NumTurnotextBox);
            this.DatosClientepanel.Controls.Add(this.label2);
            this.DatosClientepanel.Controls.Add(this.label1);
            this.DatosClientepanel.Location = new System.Drawing.Point(27, 12);
            this.DatosClientepanel.Name = "DatosClientepanel";
            this.DatosClientepanel.Size = new System.Drawing.Size(291, 125);
            this.DatosClientepanel.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Movimiento",
            "Pago de servicio",
            "Depósito",
            "Retiro",
            "Compra de tiempo-aire",
            "Consulta de saldo"});
            this.comboBox1.Location = new System.Drawing.Point(67, 91);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(104, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Tag = "Movimiento";
            // 
            // nombreClientetextBox
            // 
            this.nombreClientetextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nombreClientetextBox.Location = new System.Drawing.Point(67, 64);
            this.nombreClientetextBox.Name = "nombreClientetextBox";
            this.nombreClientetextBox.Size = new System.Drawing.Size(202, 25);
            this.nombreClientetextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cliente";
            // 
            // NumTurnotextBox
            // 
            this.NumTurnotextBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.NumTurnotextBox.Location = new System.Drawing.Point(67, 32);
            this.NumTurnotextBox.Name = "NumTurnotextBox";
            this.NumTurnotextBox.ReadOnly = true;
            this.NumTurnotextBox.Size = new System.Drawing.Size(51, 25);
            this.NumTurnotextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "No. Turno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Cliente";
            // 
            // agregarButton
            // 
            this.agregarButton.Location = new System.Drawing.Point(357, 21);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(68, 42);
            this.agregarButton.TabIndex = 1;
            this.agregarButton.Text = "Agregar a la cola";
            this.agregarButton.UseVisualStyleBackColor = true;
            this.agregarButton.Click += new System.EventHandler(this.agregarButton_Click_1);
            // 
            // atenderButton
            // 
            this.atenderButton.Location = new System.Drawing.Point(357, 69);
            this.atenderButton.Name = "atenderButton";
            this.atenderButton.Size = new System.Drawing.Size(68, 42);
            this.atenderButton.TabIndex = 3;
            this.atenderButton.Text = "Atender en ventanilla";
            this.atenderButton.UseVisualStyleBackColor = true;
            this.atenderButton.Click += new System.EventHandler(this.atenderButton_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.Location = new System.Drawing.Point(10, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(432, 126);
            this.dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No. Turno";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cliente";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Movimiento";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Hora llegada";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(357, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 36);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salida del sistema";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // turnoActualLabel
            // 
            this.turnoActualLabel.AutoSize = true;
            this.turnoActualLabel.Location = new System.Drawing.Point(41, 147);
            this.turnoActualLabel.Name = "turnoActualLabel";
            this.turnoActualLabel.Size = new System.Drawing.Size(35, 13);
            this.turnoActualLabel.TabIndex = 7;
            this.turnoActualLabel.Text = "label5";
            // 
            // turnoAtendidoLabel
            // 
            this.turnoAtendidoLabel.AutoSize = true;
            this.turnoAtendidoLabel.Location = new System.Drawing.Point(41, 173);
            this.turnoAtendidoLabel.Name = "turnoAtendidoLabel";
            this.turnoAtendidoLabel.Size = new System.Drawing.Size(35, 13);
            this.turnoAtendidoLabel.TabIndex = 9;
            this.turnoAtendidoLabel.Text = "label7";
            // 
            // Practica10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(454, 350);
            this.Controls.Add(this.turnoAtendidoLabel);
            this.Controls.Add(this.turnoActualLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.atenderButton);
            this.Controls.Add(this.agregarButton);
            this.Controls.Add(this.DatosClientepanel);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Practica10";
            this.Text = "Form1";
            this.DatosClientepanel.ResumeLayout(false);
            this.DatosClientepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel DatosClientepanel;
        private TextBox NumTurnotextBox;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private TextBox nombreClientetextBox;
        private Label label3;
        private Button agregarButton;
        private Button atenderButton;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private Button button1;
        private Label turnoActualLabel;
        private Label turnoAtendidoLabel;
    }
}
