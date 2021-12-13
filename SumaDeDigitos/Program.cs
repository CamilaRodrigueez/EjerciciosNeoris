using System;

namespace SumaDeDigitos
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Por favor Dime un número: ");
            string numero = Console.ReadLine();
            int contador = numero.Length;
            Console.WriteLine($"El número {numero} tiene {contador} dígitos");
            Console.ReadKey();
            
        }
    }
}
