using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Utilidades
    {
        public static bool sonLetras(string a)
        {
            string abecedario = "abcdefghijklmnñopqrstuvwxyz";

            foreach (var letra in a)
            {
                foreach (var letraAbc in abecedario)
                {
                    if (letra == letraAbc)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
