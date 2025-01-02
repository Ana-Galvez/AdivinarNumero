using System;

namespace AdivinarNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            byte randNumber = (byte)rand.Next(0,101);
            byte number;
            Console.WriteLine("Bienvenido a adivina el número");
            Console.WriteLine("Escribe un número del 0 al 100");
            do {
                try
                {
                    number = byte.Parse(Console.ReadLine());
                    if (number < randNumber) Console.WriteLine($"El número {number} es menor al número correcto");
                    else Console.WriteLine($"El número {number} es mayor al número correcto");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingreso inválido. Ingrese entre 0 a 100");
                    number = 0;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Número inválido. Debe elegir entre 0 a 100");
                    number = 0;
                }

                // Si tuvieramos muchas excepciones conviene usar Exception que es el padre de todas las excepciones)
                //catch (Exception e) 
                //{
                //    Console.WriteLine("Ingreso inválido. Ingrese entre 0 a 100");
                //    number = 0;
                //    Console.WriteLine(e.Message);
                //}

                // verifica si el usuario ingresó un número
                //while (!Int32.TryParse(Console.ReadLine(), out number))
                //{
                //    Console.WriteLine("Operación inválida. Ingrese entre 0 a 100");
                //};

                // verifica que el usuario ingrese entre 0 al 100
            } while (number != randNumber);
            Console.WriteLine("FELICIDADES ACERTASTE EL NÚMERO");
        }
    }
}
