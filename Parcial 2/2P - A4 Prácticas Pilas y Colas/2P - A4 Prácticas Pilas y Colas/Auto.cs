using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2P___A4_Prácticas_Pilas_y_Colas
{
    internal class Auto
    {
        public string Placas { get; set; }
        public string Propietario { get; set; }
        public DateTime HoraEntrada { get; set; }
        public DateTime HoraSalida { get; set; }

        public Auto(string placas, string propietario)
        {
            Placas = placas;
            Propietario = propietario;
            HoraEntrada = DateTime.Now;
        }

        public double CalcularCosto()
        {
            TimeSpan tiempoEstacionado = HoraSalida - HoraEntrada;
            return tiempoEstacionado.TotalSeconds * 2.00;
        }
    }
}
