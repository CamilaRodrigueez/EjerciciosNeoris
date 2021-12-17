using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorPromedio.Logica
{
   public  class MayorQueElProm
    {
        List<double> valor = new List<double>();
        int dato;

        public MayorQueElProm()
        {
            PrepararData();
        }
        private void PrepararData()
        {
            Console.Write("¿Cuántos Datos ingresará? ");
            dato = Convert.ToInt32(Console.ReadLine());
            double number;
            for (int i = 0; i < dato; i++)
            {
                Console.Write($"Dato {i+1}: ");
                number = Convert.ToDouble(Console.ReadLine());
                valor.Add(number);
            }
            
        }

        public void CalcularMayorQueElPromedio()
        {
           
            var promedio = valor.Average();
            Console.WriteLine(promedio);
            int count = 0;
            foreach (var item in valor)
            {
                if (item>promedio)
                {
                    count++;
                }
            }
            Console.WriteLine($"{count} datos son mayores que el promedio");
 
        }

    }
}
