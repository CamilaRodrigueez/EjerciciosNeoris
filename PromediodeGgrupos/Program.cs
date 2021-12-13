using System;

namespace PromediodeGgrupos
{
    class Program
    {
        static void Main(string[] args)
        {
              
            double suma1, suma2, suma3, c1, c2, c3;
            Console.WriteLine("Ingrese el Total de grupos");
            int grupos = int.Parse(Console.ReadLine());
            suma3 = 0;
            for (int i = 0; i < grupos; i++)
            {
                Console.WriteLine("Ingrese el total de alumnos");
                int alumnos = int.Parse(Console.ReadLine());
                suma2 = 0;
                for (int a = 0; a < alumnos; a++)
                {
                    Console.WriteLine("Ingrese el total de materias");
                    int materias = int.Parse(Console.ReadLine());
                    suma1 = 0;
                    for (int b = 0; b < materias; b++)
                    {
                        Console.Write("Digite calificacion 1: ");
                        c1 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite calificacion 2: ");
                        c2 = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Digite calificacion 3: ");
                        c3 = Convert.ToDouble(Console.ReadLine());
                        suma1 += (c1 + c2 + c3) / 3;
                    }
                    Console.WriteLine($"El promedio del alumno {a} es: ",suma1/materias);
                    suma1 += (suma1 / materias);
                }
                Console.WriteLine($"El promedio del grupo {i} es: ",suma2/alumnos);
                suma3 += (suma2 / alumnos);
            }
            Console.WriteLine($"El promedio de los {grupos} grupos es:",suma3/grupos);

            
            Console.ReadKey();
           
        }
       
        
    }
}
