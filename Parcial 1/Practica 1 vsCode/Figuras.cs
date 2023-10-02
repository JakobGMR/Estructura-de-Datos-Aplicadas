using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TDA_Ejemplo
{
    public partial class Figuras : Form
    {
        public Figuras()
        {
            

            Button nuevoBoton = new Button();
            nuevoBoton.Text = "Mi Botón";
            nuevoBoton.Location = new System.Drawing.Point(100, 100);
            this.Controls.Add(nuevoBoton);

            Button Button0 = new Button();
            Button0.Text =  "Circulo";
            Button0.Location = new System.Drawing.Point(28,36);
            this.Controls.Add(Button0);

            InitializeComponent();            
        }

        this.Button0 = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.Button9 = new System.Windows.Forms.Button();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Panel4.SuspendLayout();
            this.SuspendLayout();
            //
            // Button0
            //
            this.Button0.Text =  "Circulo";
            this.Button0.Location = new System.Drawing.Point(24,28);
            //
            // Button1
            //
            this.Button1.Text =  "Rectangulo";
            this.Button1.Location = new System.Drawing.Point(140,28);
            this.Button1.TabIndex = 1;
            //
            // Button2
            //
            this.Button2.Text =  "Triangulo Equilatero";
            this.Button2.Location = new System.Drawing.Point(236,28);
            this.Button2.Size = new System.Drawing.Size(120,23);
            this.Button2.TabIndex = 2;
            //
            // Button3
            //
            this.Button3.Text =  "Cuadrado";
            this.Button3.Location = new System.Drawing.Point(376,28);
            this.Button3.TabIndex = 3;
            //
            // Panel4
            //
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.TextBox6);
            this.Panel4.Controls.Add(this.Label7);
            this.Panel4.Controls.Add(this.TextBox8);
            this.Panel4.Controls.Add(this.Button9);
            this.Panel4.Controls.Add(this.Label10);
            this.Panel4.Controls.Add(this.Label11);
            this.Panel4.Controls.Add(this.Label12);
            this.Panel4.Controls.Add(this.Label13);
            this.Panel4.Text =  "Panel4";
            this.Panel4.Location = new System.Drawing.Point(24,80);
            this.Panel4.Size = new System.Drawing.Size(420,180);
            this.Panel4.TabIndex = 4;
            //
            // Label5
            //
            this.Label5.AutoSize =  true;
            this.Label5.Text =  "Base";
            this.Label5.Location = new System.Drawing.Point(52,12);
            this.Label5.Size = new System.Drawing.Size(31,15);
            this.Label5.TabIndex = 5;
            //
            // TextBox6
            //
            this.TextBox6.Location = new System.Drawing.Point(20,32);
            this.TextBox6.TabIndex = 6;
            //
            // Label7
            //
            this.Label7.AutoSize =  true;
            this.Label7.Text =  "Altura";
            this.Label7.Location = new System.Drawing.Point(300,12);
            this.Label7.Size = new System.Drawing.Size(39,15);
            this.Label7.TabIndex = 7;
            //
            // TextBox8
            //
            this.TextBox8.Location = new System.Drawing.Point(268,32);
            this.TextBox8.TabIndex = 8;
            //
            // Button9
            //
            this.Button9.Text =  "Calcular";
            this.Button9.Location = new System.Drawing.Point(160,64);
            this.Button9.TabIndex = 9;
            //
            // Label10
            //
            this.Label10.AutoSize =  true;
            this.Label10.Text =  "Area:";
            this.Label10.Location = new System.Drawing.Point(48,128);
            this.Label10.Size = new System.Drawing.Size(34,15);
            this.Label10.TabIndex = 10;
            //
            // Label11
            //
            this.Label11.AutoSize =  true;
            this.Label11.Text =  "Label11";
            this.Label11.Location = new System.Drawing.Point(100,128);
            this.Label11.Size = new System.Drawing.Size(47,15);
            this.Label11.TabIndex = 11;
            //
            // Label12
            //
            this.Label12.AutoSize =  true;
            this.Label12.Text =  "Perimetro:";
            this.Label12.Location = new System.Drawing.Point(248,128);
            this.Label12.Size = new System.Drawing.Size(62,15);
            this.Label12.TabIndex = 12;
            //
            // Label13
            //
            this.Label13.AutoSize =  true;
            this.Label13.Text =  "Label13";
            this.Label13.Location = new System.Drawing.Point(332,128);
            this.Label13.Size = new System.Drawing.Size(47,15);
            this.Label13.TabIndex = 13;
         //

        
    }
}