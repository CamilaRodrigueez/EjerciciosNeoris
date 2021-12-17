using ProduccionAutos.Logica;
using System;

namespace ProduccionAutos
{
    class Program
    {
        static void Main(string[] args)
        {
            AutosLogica objAutosLogica = new AutosLogica();
            objAutosLogica.CostoUnidadesSemanal();
            objAutosLogica.CostoPorModelo();
        }
    }
}
