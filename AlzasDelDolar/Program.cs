using System;
using System.Collections.Generic;
namespace AlzasDelDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double alzas = 0;
            Console.Write("¿Cuántos días? ");
            N = int.Parse(Console.ReadLine());
            double[] precio = new double[N];
            double resta = 0;
            for (int i = 1; i <= precio.Length; i++)
            {
                Console.Write($"Día {i}: ");
                precio[i] = Convert.ToDouble(Console.ReadLine());
                resta = 0;
                for (int a = 1; a < precio.Length; a++)
                {
                    resta = precio[i + 1] - precio[i];
                    
                }
                if (precio[i + 1] > resta)
                {
                    Console.WriteLine($"La mayor alza fué de {precio[i + 1]}");
                }
                else
                {
                    Console.WriteLine("No hubo alzas.");

                }

            Console.WriteLine(alzas);
        }
       
    }
}
