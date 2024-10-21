using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISNP008524
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Numero positivo o negativo");
                Console.WriteLine("2. Tabla de multipliar");
                Console.WriteLine("3. Sumar números positivos");
                Console.WriteLine("4. numeros primos");
                Console.WriteLine("5. acumulador");
                Console.WriteLine("6. Salir");
                Console.Write("Selecciona una opción: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        PositivoONegativo();
                        break;
                    case 2:
                        TablaMultiplicar();
                        break;
                    case 3:
                        SumarNumerosPositivos();
                        break;
                    case 4:
                        NumeroPrimo();
                        break;
                    case 5:
                        PromedioNumeros();
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }
            }
        }

        static void PositivoONegativo()
        {
            double numero;

            do
            {
                Console.Write("Ingresa un número (0 para detener): ");
                numero = Convert.ToDouble(Console.ReadLine());

                if (numero > 0)
                {
                    Console.WriteLine(" El número ",numero, " es positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("El número ", numero, " es negativo.");
                }
            } while (numero != 0);
        }

        static void TablaMultiplicar()
        {
            int numero;

            do
            {
                Console.Write("Ingresa un número, (0 para salir): ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero >= 1 && numero <= 10)
                {
                    for (int i = 1; i <= 1000000; i++)
                    {
                        Console.WriteLine($"{numero} x {i} = {numero * i}");
                    }
                }
                else if (numero != 0)
                {
                    Console.WriteLine("Número no valido. Intenta de nuevo.");
                }
            } while (numero != 0);
        }

        static void SumarNumerosPositivos()
        {
            double numero;
            double suma = 0;

            do
            {
                Console.WriteLine("Ingresa solo numeros posivos, (0 para salir)");
                Console.Write("Ingresa un número positivo: ");
                numero = Convert.ToDouble(Console.ReadLine());

                if (numero > 0)
                {
                    suma += numero;
                }
            } while (numero > 0);

            Console.WriteLine($"La suma de los positivos es: {suma}");
        }

        static void NumeroPrimo()
        {
            Console.Write("Ingresa un número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            bool esPrimo = true;

            if (numero <= 1)
            {
                esPrimo = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }
            }

            if (esPrimo)
            {
                Console.WriteLine("El número", esPrimo, "es primo.");
            }
            else
            {
                Console.WriteLine("El número",esPrimo, "no es primo.");
            }
        }

        static void PromedioNumeros()
        {
            double numero;
            double suma = 0;
            int contador = 0;

            do
            {
                Console.Write("Ingresa un número (0 para finalizar): ");
                numero = Convert.ToDouble(Console.ReadLine());

                if (numero != 0)
                {
                    suma += numero;
                    contador++;
                }
            } while (numero != 0);

            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine($"El promedio de los números ingresados es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron números.");
            }
        }
    }
    
}
