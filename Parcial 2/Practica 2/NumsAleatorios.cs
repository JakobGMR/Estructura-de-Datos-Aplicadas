using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    internal class NumsAleatorios
    {
        decimal[] numeros = new decimal[20];
        List<decimal> pares = new List<decimal>();
        List<decimal> inpares = new List<decimal>();
        public NumsAleatorios() { }

        public decimal[] Numeros { get => numeros; set => numeros = value; }
        public List<decimal> Pares { get => pares; set => pares = value; }
        public List<decimal> Inpares { get => inpares; set => inpares = value; }

        public void GenerarNums()
        {
            Pares.Clear();
            Inpares.Clear();

            Random numero = new Random();
            for (int i = 0; i < 20; i++)
            {
                Numeros[i] = numero.Next(1, 100);

                if (Numeros[i] % 2 == 0)
                    Pares.Add(Numeros[i]);
                else
                    Inpares.Add(Numeros[i]);
            }
        }

        public void MostrarNumeros()
        {
            
        }
    }
}
