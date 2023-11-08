namespace Practica_3
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
            DatosClientepanel = new Panel();
            comboBox1 = new ComboBox();
            nombreClientetextBox = new TextBox();
            label3 = new Label();
            NumTurnotextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            agregarButton = new Button();
            atenderButton = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            DatosClientepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DatosClientepanel
            // 
            DatosClientepanel.BackColor = Color.Plum;
            DatosClientepanel.Controls.Add(comboBox1);
            DatosClientepanel.Controls.Add(nombreClientetextBox);
            DatosClientepanel.Controls.Add(label3);
            DatosClientepanel.Controls.Add(NumTurnotextBox);
            DatosClientepanel.Controls.Add(label2);
            DatosClientepanel.Controls.Add(label1);
            DatosClientepanel.Location = new Point(12, 12);
            DatosClientepanel.Name = "DatosClientepanel";
            DatosClientepanel.Size = new Size(336, 166);
            DatosClientepanel.TabIndex = 0;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Movimiento", "Pago de servicio", "Depósito", "Retiro", "Compra de tiempo-aire", "Consulta de saldo" });
            comboBox1.Location = new Point(78, 105);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 5;
            comboBox1.Tag = "Movimiento";
            // 
            // nombreClientetextBox
            // 
            nombreClientetextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            nombreClientetextBox.Location = new Point(78, 74);
            nombreClientetextBox.Name = "nombreClientetextBox";
            nombreClientetextBox.Size = new Size(235, 25);
            nombreClientetextBox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 79);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 3;
            label3.Text = "Cliente";
            // 
            // NumTurnotextBox
            // 
            NumTurnotextBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            NumTurnotextBox.Location = new Point(78, 37);
            NumTurnotextBox.Name = "NumTurnotextBox";
            NumTurnotextBox.ReadOnly = true;
            NumTurnotextBox.Size = new Size(59, 25);
            NumTurnotextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 1;
            label2.Text = "No. Turno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 19);
            label1.TabIndex = 0;
            label1.Text = "Datos del Cliente";
            // 
            // agregarButton
            // 
            agregarButton.Location = new Point(367, 37);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(79, 48);
            agregarButton.TabIndex = 1;
            agregarButton.Text = "Agregar a la cola";
            agregarButton.UseVisualStyleBackColor = true;
            agregarButton.Click += agregarButton_Click;
            // 
            // atenderButton
            // 
            atenderButton.Location = new Point(367, 117);
            atenderButton.Name = "atenderButton";
            atenderButton.Size = new Size(79, 48);
            atenderButton.TabIndex = 3;
            atenderButton.Text = "Atender en ventanilla";
            atenderButton.UseVisualStyleBackColor = true;
            atenderButton.Click += atenderButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(12, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(434, 150);
            dataGridView1.TabIndex = 4;
            // 
            // Column1
            // 
            Column1.HeaderText = "No. Turno";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Cliente";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Movimiento";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Hora llegada";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(621, 362);
            Controls.Add(dataGridView1);
            Controls.Add(atenderButton);
            Controls.Add(agregarButton);
            Controls.Add(DatosClientepanel);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "Form1";
            Text = "Form1";
            DatosClientepanel.ResumeLayout(false);
            DatosClientepanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
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
    }
}