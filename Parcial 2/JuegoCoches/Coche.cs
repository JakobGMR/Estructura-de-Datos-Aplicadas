using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoCoches
{
    internal class Coche
    {
        private string[] colores = { "Amarillo","Azul","Morado","Naranja","Negro","Rojo","Rosa","Verde" };
        public string Color { get; set; }
        public Image imgCol { get; set; } = Image.FromFile("../../../Img/imgCarBlanco.png");
        private Random numRandom = new Random();

        public Coche()
        {

            Color = colores[numRandom.Next(0,8)];
        }
    }
}
