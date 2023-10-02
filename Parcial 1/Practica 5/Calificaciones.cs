public class Calificaciones
{
    decimal[,] calificaciones = new decimal[12,3];
    decimal[] promedioAlumno = new decimal[12];
    public Calificaciones() {

    }

    public void GenerarCalificaciones() {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Random numero = new Random();
                calificaciones[i,j] = (decimal)numero.NextDouble() * 10;
                calificaciones[i,j] = Math.Round(calificaciones[i,j],2);

                if (calificaciones[i,j] < 3)
                {
                    calificaciones[i,j] += 4;
                }

                else if (calificaciones[i,j] >= 3 && calificaciones[i,j] < 5)
                {
                    calificaciones[i,j] += 2.5M;
                }
            }
        }

        PromedioAlumno();
        Interfaz();
    }

    public void Interfaz() {
        while (true)
        {
            Console.WriteLine(" Calificaciones \n");

            Console.WriteLine("1.- Mostrar calificaciones");
            Console.WriteLine("2.- Promedio por alumno");
            Console.WriteLine("3.- Mayor promedio");
            Console.WriteLine("4.- Menor promedio");
            Console.WriteLine("5.- Parciales reprobados");
            Console.WriteLine("6.- Distribución de las calificaciones finales");
            Console.WriteLine("7.- Cerrar");

            Console.Write("\n Opción: "); string eleccion = Console.ReadLine()!;

            switch (eleccion)
            {
                case "1":
                Console.Clear();
                PrintArray();
                Console.Clear();
                break;

                case "2":
                Console.Clear();
                ImprimirPromedio();
                Console.Clear();
                break;

                case "3":
                Console.Clear();
                PromedioAlto();
                Console.Clear();
                break;

                case "4":
                Console.Clear();
                PromedioBajo();
                Console.Clear();
                break;

                case "5":
                Console.Clear();
                ParcialesReprobados();
                Console.Clear();
                break;

                case "6":
                Console.Clear();
                DistribucionProm();
                Console.Clear();
                break;

                case "7":
                    Console.Clear(); Console.WriteLine("Volviendo"); Thread.Sleep(1000); Console.Clear();
                return;

                default:
                Console.Clear();
                System.Console.WriteLine("Error, intentelo de nuevo \n Pulse una tecla");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }
    }

    public void PrintArray() {
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                System.Console.Write($"{calificaciones[i,j]}  |");
                Thread.Sleep(300);
            }
            System.Console.WriteLine();
        }

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public void ImprimirPromedio() {
        System.Console.WriteLine("  Promedio por alumno \n");

        for (int i = 0; i < 12; i++)
        {
            System.Console.WriteLine($"Alumno {i+1}: {promedioAlumno[i]}");
            Thread.Sleep(300);
        }

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public void PromedioAlumno() {
        for (int i = 0; i < 12; i++)
        {
            promedioAlumno[i] = 0;

            for (int j =0; j < 3; j++)
            {
                promedioAlumno[i] += calificaciones[i,j];
            }

            promedioAlumno[i] /= 3;
            promedioAlumno[i] = Math.Round(promedioAlumno[i],2);
        }
    }

    public void PromedioAlto() {
        decimal promAlta = 0;

        for (int i = 0; i < 12; i++)
        {
            if (i == 0)  promAlta = promedioAlumno[i];

            else if(promAlta >= promedioAlumno[i])  continue;

            else  promAlta = promedioAlumno[i];
        }

        for (int i = 0; i < 12; i++)
        {
            if (promedioAlumno[i] == promAlta)
            {
                System.Console.WriteLine($"Alumno #{i+1}: {promAlta}");
            }
        }

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public void PromedioBajo() {
        decimal promBaja = 0;

        for (int i = 0; i < 12; i++)
        {
            if (i == 0)  promBaja = promedioAlumno[i];

            else if(promBaja <= promedioAlumno[i])  continue;

            else  promBaja = promedioAlumno[i];
        }

        for (int i = 0; i < 12; i++)
        {
            if (promedioAlumno[i] == promBaja)
            {
                System.Console.WriteLine($"Alumno #{i+1}: {promBaja}");
            }
        }

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public void ParcialesReprobados() {
        int parciReprob = 0;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (calificaciones[i,j] < 7)
                {
                    parciReprob++;
                }
            }
        }

        System.Console.WriteLine("La cantidad de parciales reprobados es de: " + parciReprob);
        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }

    public void DistribucionProm() {
        int[] distribucion = new int[6];
        for (int i = 0; i < 12; i++)
        {
            if (promedioAlumno[i] < 5)  distribucion[0]++;

            else if(promedioAlumno[i] >= 5 && promedioAlumno[i] < 6)  distribucion[1]++;

            else if(promedioAlumno[i] >= 6 && promedioAlumno[i] < 7)  distribucion[2]++;

            else if(promedioAlumno[i] >= 7 && promedioAlumno[i] < 8)  distribucion[3]++;

            else if(promedioAlumno[i] >= 8 && promedioAlumno[i] < 9)  distribucion[4]++;

            else  distribucion[5]++;
        }

        System.Console.WriteLine($"Calificación de 0 - 4.9: {distribucion[0]} alumnos"); Thread.Sleep(300);
        System.Console.WriteLine($"Calificación de 5 - 5.9: {distribucion[1]} alumnos");
        System.Console.WriteLine($"Calificación de 6 - 6.9: {distribucion[2]} alumnos");
        System.Console.WriteLine($"Calificación de 7 - 7.9: {distribucion[3]} alumnos");
        System.Console.WriteLine($"Calificación de 8 - 8.9: {distribucion[4]} alumnos");
        System.Console.WriteLine($"Calificación de 9 - 10: {distribucion[5]} alumnos");

        System.Console.WriteLine("\n Pulse una tecla");
        Console.ReadKey();
    }
}