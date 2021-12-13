using System;
using System.Collections.Generic;
using System.Linq;

namespace AgenciadeViajes
{
    class Program
    {

        static void Main(string[] args)
        {
            decimal recaudo1 = 0;
            decimal recaudo2 = 0;
            decimal recaudo3 = 0;
            string destino1, destino2, destino3;
            decimal valor1, valor2, valor3;

            Console.Write("Ingrese Destino 1: ");
            destino1 = Console.ReadLine();
            Console.WriteLine($"Digite el valor del vuelo hacia {destino1} ");
            valor1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Cuántas personas viajarán a {destino1} el día de Hoy?");
            int cant = Convert.ToInt32(Console.ReadLine());
            recaudo1 = cant * valor1;
            Console.WriteLine($"Total Recaudo {destino1} Hoy: {recaudo1}");
            Console.Write("Ingrese Destino 2: ");
            destino2 = Console.ReadLine();
            Console.WriteLine($"Digite el valor del vuelo hacia {destino2}");
            valor2 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Cuántas personas viajarán a {destino2} el día de Hoy?");
            int cant1 = Convert.ToInt32(Console.ReadLine());
            recaudo2 = cant1 * valor2;
            Console.WriteLine($"Total Recaudo {destino2} Hoy: {recaudo2}");
            Console.Write("Ingrese Destino 3: ");
            destino3 = Console.ReadLine();
            Console.WriteLine($"Digite el valor del vuelo hacia {destino3} ");
            valor3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine($"Cuántas personas viajarán a {destino3} el día de Hoy?");
            int cant3 = Convert.ToInt32(Console.ReadLine());
            recaudo3 = cant3 * valor3;
            Console.WriteLine($"Total Recaudo {destino3} Hoy: {recaudo3}");
            Console.ReadKey();
            Console.Clear();
            decimal recaudoTotal = 0;
            recaudoTotal = (recaudo1 + recaudo2 + recaudo3);
            Console.WriteLine($"La cantidad de recaudo total por todos los detinos es de: {recaudoTotal}");
            decimal recaudoDescuento;
            decimal recaudoDes;
            if (recaudoTotal > 500000 && recaudoTotal < 1000000)
            {
                recaudoDescuento = recaudoTotal * 0.05m;
                Console.WriteLine("Descuento del 5%");
                recaudoDes = recaudoTotal - recaudoDescuento;
                Console.WriteLine($"El descuento del IVA fue de {recaudoDes}");
                Console.WriteLine($"El total recaudo menos el IVA es de: {recaudoDescuento}");
            }
            else if(recaudoTotal > 1000000 && recaudoTotal < 1500000)
            {
                recaudoDescuento = recaudoTotal * 0.1M;
                Console.WriteLine("Descuento del 10%");
                recaudoDes = recaudoTotal - recaudoDescuento;
                Console.WriteLine($"El descuento del IVA fue de {recaudoDes}");
                Console.WriteLine($"El total recaudo menos el IVA es de: {recaudoDescuento}");
            }
            else
            {
                recaudoDescuento = recaudoTotal * 0.2m;
                Console.WriteLine("Descuento del 20%");
                recaudoDes = recaudoTotal - recaudoDescuento;
                Console.WriteLine($"El descuento del IVA fue de {recaudoDes}");
                Console.WriteLine($"El total recaudo menos el IVA es de: {recaudoDescuento}");
            }

        }





    }
}
