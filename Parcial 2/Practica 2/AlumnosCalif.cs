using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_2
{
    public class AlumnosCalif
    {
        public string Nombre { get; set; } = string.Empty;
        public decimal Calif { get; set; }

        public AlumnosCalif(string nombre)
        {
            this.Nombre = nombre;
        }
    }
}
