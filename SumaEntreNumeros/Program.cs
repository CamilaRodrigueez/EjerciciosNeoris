using System;

namespace SumaEntreNumeros
{
    class Program
    {     
        static void Main(string[] args)
        {
            int suma=0, num1=0, num2=0;

           
                Console.Write("Por favor ingrese el número 1: ");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Por favor ingrese el número 2: ");
                num2 = Convert.ToInt32(Console.ReadLine());


            while (num1<num2-1)
            {
                num1 = num1 + 1;
                suma= suma+ num1;
            }
            Console.WriteLine($"La suma es: {suma}");
            
            
        }
       
    }
}
