using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class Producto
    {
            public string Name { get; set; } = string.Empty;
            public double Price { get; set; } = double.MaxValue;
            public int Qty { get; set; }

        public Producto(string name)
        {
            this.Name = name;
            Qty = new Random().Next(100);
            Price = Double.Round(new Random().NextDouble() * 100, 2);
        }
    }
}
