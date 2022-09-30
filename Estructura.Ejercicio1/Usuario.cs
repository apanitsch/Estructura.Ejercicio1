using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Usuario
{
    public static int PedirEntero(string mensaje, int min, int max)
    {
        //tenemos que devolver si o si un entero 
        //entre min y max ingresado por el usuario.
        while (true)
        {
            Console.WriteLine(mensaje);
            string ingreso = Console.ReadLine();
            bool correcto = int.TryParse(ingreso, out int entero);

            if (!correcto) //si algo no está bien.
            {
                //=>mensaje de error diciendo qué es ese "algo"
                Console.WriteLine("No ha ingresado un entero válido");
                //salir, reintentar o continuar.
                continue;
            }

            //llega sólo si correcto=true
            if (entero < min) //si algo NO está bien
            {
                Console.WriteLine($"El mínimo es {min}");
                continue;
            }

            //es entero y no es menor al minimo
            if (entero > max)
            {
                Console.WriteLine($"El máximo es {max}");
                continue;
            }

            //siempre al final de todos los ifs se llega
            //"si está todo bien"
            //=> devuelvo el entero.
            return entero;
        }
    }

    internal static string PedirCadena(string mensaje, int max)
    {
        while (true)
        {
            Console.WriteLine(mensaje);
            string ingreso = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(ingreso))
            {
                Console.WriteLine("Ingrese algo");
                continue;
            }

            if (ingreso.Length > 30)
            {
                Console.WriteLine("Ingrese hasta 30 caracteres.");
                continue;
            }

            //larga y entendible.
            bool estaOk = true;
            foreach (char caracter in ingreso)
            {
                if (caracter > '0' && caracter < '9')
                {
                    Console.WriteLine("No ingrese números.");
                    estaOk = false;
                    break;
                }
            }
            if (!estaOk)
            {
                continue;
            }

            //como se escribe
            //if (ingreso.Any(c => Char.IsDigit(c)))
            //{
            //
            //}

            return ingreso;
        }
    }

    internal static DateTime PedirFecha(string mensaje, DateTime max)
    {
        while (true)
        {
            Console.Write(mensaje);
            string ingreso = Console.ReadLine();

            if (!DateTime.TryParse(ingreso, out DateTime fecha))
            {
                Console.Write("Ingrese una fecha válida");
                continue;
            }

            if (fecha > max)
            {
                Console.WriteLine($"La fecha máxima es {max}");
                continue;
            }

            return fecha;
        }
    }
}
