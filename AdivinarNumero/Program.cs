using System;

namespace AdivinarNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int randNumber =rand.Next(0,101);
            int number;
            Console.WriteLine("Bienvenido a adivina el número");
            Console.WriteLine("Escribe un número del 0 al 100");
            do {
                number = Int32.Parse(Console.ReadLine());
                // verifica si el usuario ingresó un número
                //while (!Int32.TryParse(Console.ReadLine(), out number))
                //{
                //    Console.WriteLine("Operación inválida. Ingrese entre 0 a 100");
                //};

                // verifica que el usuario ingrese entre 0 al 100
                if (number >= 0 && number <= 100)
                {
                    if (number < randNumber) Console.WriteLine($"El número {number} es menor al número correcto");
                    else Console.WriteLine($"El número {number} es mayor al número correcto");
                }
                else Console.WriteLine("Número inválido. Debe elegir entre 0 a 100");
            } while (number != randNumber);
            Console.WriteLine("FELICIDADES ACERTASTE EL NÚMERO");
        }
    }
}
