using System;

namespace EjerciciosNeoris
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numAleatorio = new();
            int n = numAleatorio.Next(100), contIntentos = 0, num;
           
                do
                {
                    Console.Write("Por favor ingrese un número entre 1 y 100: ");
                    num = Convert.ToInt32(Console.ReadLine());
                    contIntentos++;
                    if (num > n) Console.WriteLine("1");
                    else if (num < n) Console.WriteLine("2");
                } while (num != n);
            Console.WriteLine("3");
           
            Console.WriteLine($"Has adivinado en: {contIntentos} intentos");
            Console.ReadKey();
           
        }
    }
}
