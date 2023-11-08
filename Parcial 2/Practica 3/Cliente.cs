using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_3
{
    internal class Cliente
    {
        public int Turno {  get; set; }
        public string Nombre { get; set; }
        public string Movimiento { get; set; }
        public DateTime Llegada { get; set; }

        public Cliente(string nombre, string movimiento, int turno) {
            this.Nombre = nombre;
            this.Movimiento = movimiento;
            this.Turno = turno;
            Llegada = DateTime.Now;
        }
    }
}
