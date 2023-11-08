using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pratica11_12_13
{
    internal class CuadroMagico
    {
        int filas;
        int columnas;
        int[,] cuadro;
        public CuadroMagico(int filas, int columnas)
        {
            this.filas = filas;
            this.columnas = columnas;
            this.filas += 1; this.columnas += 1;
            this.cuadro = new int[this.filas, this.columnas];
        }

        public bool CuadroCuadrado()
        {
            if (filas == columnas && filas > 2 && columnas > 2)
            {
                return true;
            }

            else
            {
                MessageBox.Show("Este cuadro, no es un cuadro mágico");
                return false;
            }
        }

        public void RellenarValores()
        {

            for (int i = 0; i < this.filas - 1; i++)
            {
                
                for (int j = 0; j < this.filas - 1; j++)
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox($"Ingresa el valor de la casilla({i + 1}, {j + 1}):");
                    int valorCasilla;
                    if (int.TryParse(input, out valorCasilla))
                    {
                        this.cuadro[i, j] = valorCasilla;
                    }
                    else
                    {
                        MessageBox.Show("Número inválido. Inténtelo de nuevo.");
                    }
                    
                }
            }
            SumaValores();
        }

        public void SumaValores()
        {
            for (int i = 0; i < this.filas; i++)
            {
                if (i != this.filas - 1)
                {
                    for (int j = 0; j < this.filas - 1; j++)
                    {
                        this.cuadro[i, this.filas - 1] += this.cuadro[i, j];
                    }
                }
                else
                {
                    for (int j = 0; j < this.filas - 1; j++)
                    {
                        for (int k = 0; k < this.filas - 1; k++)
                        {
                            this.cuadro[i, j] += this.cuadro[k, j];
                        }
                    }
                }
            }

            for (int i = 0; i < this.filas - 1; i++)
            {
                for (int j = 0; j < filas - 1; j++)
                {
                    if (i == j)
                    {
                        this.cuadro[this.filas - 1, this.filas - 1] += this.cuadro[i, j];
                    }
                }
            }
        }

        public void PrintArray(ListBox listbox4)
        {
            listbox4.Items.Clear();
            for (int i = 0; i < filas; i++)
            {
                string fila = "";
                for (int j = 0; j < filas; j++)
                {
                    fila += ($"{this.cuadro[i, j]}  |");
                    Task.Delay(300);
                }
                listbox4.Items.Add(fila);
            }

            if (EsCuadroMagico()) MessageBox.Show("¡FELICIDADES! Creaste un cuadro mágico");

            else MessageBox.Show("Este, no es un cuadro mágico");

            System.Console.WriteLine("\n Pulse una tecla");
        }

        public bool EsCuadroMagico()
        {
            for (int i = 0; i < filas; i++)
            {
                if (i != this.filas - 1)
                {
                    if (this.cuadro[i, filas - 1] == this.cuadro[i + 1, filas - 1])
                    {
                        continue;
                    }

                    else return false;
                }

                else
                {
                    for (int j = 0; j < this.filas - 1; j++)
                    {
                        if (this.cuadro[i, j] == this.cuadro[i, j + 1])
                        {
                            continue;
                        }

                        else return false;
                    }
                }
            }

            return true;
        }
    }
}
