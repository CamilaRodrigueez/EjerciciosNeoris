using ProduccionAutos.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionAutos.Logica
{
    public class AutosLogica
    {
        int precioMaterial = 5, precioPersonal = 15, precioImpuestos = 7, precioTransporte = 2,
            costoSedanes=60, costoCamionetas=40, costoEconomicos=90;

        private List<AutosModels> ListaAutos;
        public AutosLogica()
        {
            PrepararData();
        }
        private void PrepararData()
        {
            ListaAutos = new List<AutosModels>();

            ListaAutos.Add(new AutosModels()
            { 
                Costos="Material",
                Sedan=7,
                Camioneta=8,
                Economico=5  
            });
            ListaAutos.Add(new AutosModels()
            {
                Costos = "Personal",
                Sedan=10,
                Camioneta=9,
                Economico=7
            });
            ListaAutos.Add(new AutosModels()
            {
                Costos = "Impuestos",
                Sedan=5,
                Camioneta=3,
                Economico=2
            });
            ListaAutos.Add(new AutosModels()
            {
                Costos="Transporte",
                Sedan=2,
                Camioneta=3,
                Economico=1
            });
        }
        public void CostoUnidadesSemanal()
        {
            AutosModels autosMaterial = ListaAutos.FirstOrDefault(x => x.Costos == "Material");
            int resultado1 = 0, resultado2 = 0, resultado3 = 0, resultado4=0;
            resultado1 = (autosMaterial.Sedan * costoSedanes);
            resultado1 = resultado1+(autosMaterial.Camioneta * costoCamionetas);
            resultado1 = resultado1+(autosMaterial.Economico * costoEconomicos);

            AutosModels autosPersonal = ListaAutos.FirstOrDefault(x => x.Costos == "Personal");
            resultado2 = (autosPersonal.Sedan * costoSedanes);
            resultado2 = resultado2+(autosPersonal.Camioneta * costoCamionetas);
            resultado2 = resultado2+(autosPersonal.Economico * costoEconomicos);

            AutosModels autosImpuestos = ListaAutos.FirstOrDefault(x => x.Costos == "Impuestos");
            resultado3 = (autosImpuestos.Sedan * costoSedanes);
            resultado3 = resultado3+(autosImpuestos.Camioneta * costoCamionetas);
            resultado3 = resultado3+(autosImpuestos.Economico * costoEconomicos);

            AutosModels autosTransporte = ListaAutos.FirstOrDefault(x => x.Costos == "Transporte");
            resultado4 = (autosTransporte.Sedan * costoSedanes);
            resultado4 = resultado4+(autosTransporte.Camioneta * costoCamionetas);
            resultado4 = resultado4+(autosTransporte.Economico * costoEconomicos);
            Console.WriteLine("Las unidades semanales necesarias de:");
            Console.WriteLine();
            Console.WriteLine($"Material..: {resultado1}");
            Console.WriteLine($"Personal..: {resultado2}");
            Console.WriteLine($"Impuestos.: {resultado3}");
            Console.WriteLine($"Transporte: {resultado4}");
        }
        public void CostoPorModelo()
        {
            AutosModels autosMaterial = ListaAutos.FirstOrDefault(x => x.Costos == "Material");
            int resultado1 = 0, resultado2 = 0, resultado3 = 0;
            resultado1 = (autosMaterial.Sedan * precioMaterial);
            resultado2 = (autosMaterial.Camioneta * precioMaterial);
            resultado3 = (autosMaterial.Economico * precioMaterial);

            AutosModels autosPersonal = ListaAutos.FirstOrDefault(x => x.Costos == "Personal");
            resultado1 = resultado1+(autosPersonal.Sedan * precioPersonal);
            resultado2 =resultado2+ (autosPersonal.Camioneta * precioPersonal);
            resultado3 =resultado3+ (autosPersonal.Economico * precioPersonal);

            AutosModels autosImpuestos = ListaAutos.FirstOrDefault(x => x.Costos == "Impuestos");
            resultado1 = resultado1+ (autosImpuestos.Sedan * precioImpuestos);
            resultado2 =resultado2+ (autosImpuestos.Camioneta * precioImpuestos);
            resultado3 = resultado3+(autosImpuestos.Economico * precioImpuestos);

            AutosModels autosTransporte = ListaAutos.FirstOrDefault(x => x.Costos == "Transporte");
            resultado1 =resultado1+ (autosTransporte.Sedan * precioTransporte);
            resultado2 = resultado2+(autosTransporte.Camioneta * precioTransporte);
            resultado3 = resultado3+(autosTransporte.Economico * precioTransporte);
            Console.WriteLine();
            Console.WriteLine("El precio Total de un Auto de Cada modelo es:");
            Console.WriteLine();
            Console.WriteLine($"Sedán....: {resultado1}");
            Console.WriteLine($"Camioneta: {resultado2}");
            Console.WriteLine($"Económico: {resultado3}");

        }
    }
}
