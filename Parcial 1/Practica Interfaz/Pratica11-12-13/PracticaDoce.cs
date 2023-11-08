using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pratica11_12_13
{
    public class PracticaDoce 
    {
        int[,] ventas;

        public PracticaDoce()
        {
            ventas = new int[12, 5];
            Random random = new Random();

            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    ventas[i, j] = random.Next(10,100);
                }
            }
        }
        public void PintarArreglo(ListBox listbox1)
        {
            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    row += ventas[i, j].ToString() + "\t"; 
                }
                listbox1.Items.Add(row.TrimEnd()); 
            }
        }

        public void BuscarVentaMinMax( ListBox listbox)
        {
            double min = ventas[0, 0];
            double max = ventas[0, 0];
            string mesMin = "";
            string diaMin = "";
            string mesMax = "";
            string diaMax = "";
            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    if (ventas[i, j] < min) // Corrige la comparación aquí
                    {
                        mesMin = GetCurrentMonth(i);
                        diaMin = GetCurrentDay(j);
                        min = ventas[i, j];
                    }

                    if (ventas[i, j] > max) // Corrige la comparación aquí
                    {
                        mesMax = GetCurrentMonth(i);
                        diaMax = GetCurrentDay(j);
                        max = ventas[i, j];
                    }
                }
            }

            listbox.Items.Add($"Venta mínima: ${min} el dia {diaMin} \n" +
                $"del mes {mesMin}");
            listbox.Items.Add($"Venta máxima: ${max} el dia {diaMax} \n" +
                $"del mes  {mesMax}");

        }



        public string GetCurrentDay(int indice)
        {
            string[] Days = { "Lunes", "Martes", "Miercoles","Jueves","Viernes" };

            return Days[indice];

        }

        public string GetCurrentMonth(int indice)
        {
            string[] Months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio",
            "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};

            return Months[indice];

        }


        public void SumaTotal(ListBox listbox)
        {
            double suma = 0;
            for (int i = 0; i < ventas.GetLength(0); i++)
            {
                for (int j = 0; j < ventas.GetLength(1); j++)
                {
                    suma += ventas[i, j];
                }
            }

            listbox.Items.Add($"La venta total fue de: ${Math.Round(suma,2)}");
        }

        public void  SumarColumnas(ListBox listbox)
        {
            int filas = ventas.GetLength(0);
            int columnas = ventas.GetLength(1);
            int[] sumaDeColumnas = new int[columnas];

            for (int j = 0; j < columnas; j++)
            {
                int suma = 0;
                for (int i = 0; i < filas; i++)
                {
                    suma += ventas[i, j];
                }
                sumaDeColumnas[j] = suma;
            }

            for (int i = 0; i < sumaDeColumnas.Length; i++)
            {
                listbox.Items.Add($"{GetCurrentDay(i)}: ${sumaDeColumnas[i]}");
            }
        }

    }
}
