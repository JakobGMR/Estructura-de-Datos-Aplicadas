using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Cuadrado: Figura
    {
        double bases;
        double altura;
        public Cuadrado()
        {

        }

        public double Bases
        {
            get { return bases; }
            set { bases = value; }
        }

        public override double area()
        {
            return (Bases * Bases);
        }

        public override double perimetro()
        {
            return (Bases * 4);
        }
    }
}
