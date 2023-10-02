namespace TDA_Ejemplo;

partial class Figuras
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
        this.Button0 = new System.Windows.Forms.Button();
        
            //
            // Button0
            //
            this.Button0.Text =  "Circulo";
            this.Button0.Location = new System.Drawing.Point(28,36);

        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Text = "Form1";
    
        Panel panel1 = new Panel();
        panel1.Location = new System.Drawing.Point(10, 10); // Cambia las coordenadas según tus necesidades
        panel1.Size = new System.Drawing.Size(300, 200); // Cambia el tamaño según tus necesidades
        this.Controls.Add(panel1);

        Panel panel2 = new Panel();
        panel2.Location = new System.Drawing.Point(10, 10); // Cambia las coordenadas según tus necesidades
        panel2.Size = new System.Drawing.Size(300, 200); // Cambia el tamaño según tus necesidades
        this.Controls.Add(panel2);
    }

    #endregion

    private System.Windows.Forms.Button Button0;
}