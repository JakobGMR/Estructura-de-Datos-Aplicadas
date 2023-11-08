using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class ProductoCodigo
    {
        public string Name { get; set; } = string.Empty;
        public double Price { get; set; } = double.MaxValue;
        public int Codigo { get; set; }
        private static int codigUniq = 101;

        public ProductoCodigo(string name)
        {
            this.Name = name;
            Codigo = codigUniq;
            Price = Double.Round(new Random().NextDouble() * 100, 2);
            codigUniq++;
        }
    }
}
