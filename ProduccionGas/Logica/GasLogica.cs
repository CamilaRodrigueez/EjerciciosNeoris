using ProduccionGas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduccionGas.Logica
{
    public class GasLogica
    {
        public void PrepararData()
        {
            List<ComponentesModels> listaComponentes = new List<ComponentesModels>()
            {
                new ComponentesModels()
                {
                    Componente="Aceite Finos",
                    Normal=10,
                    Extra=5,
                    Super=35
                },
                new ComponentesModels()
                {
                    Componente="Alquitrán",
                    Normal=15,
                    Extra=4,
                    Super=31
                },
                new ComponentesModels()
                {
                    Componente="Grasas Residuales",
                    Normal=18,
                    Extra=2,
                    Super=30
                }
            };

            List<RefineriasModels> listaRefineria = new List<RefineriasModels>()
            {
                new RefineriasModels()
                {
                    Refineria="A",
                    Normal=3000,
                    Extra=7000,
                    Super=2000
                },
                new RefineriasModels()
                {
                    Refineria="B",
                    Normal=4000,
                    Extra=500,
                    Super=600
                }
            };

            List<ComponentesModels> totalAnual = Totales_Anuales(listaRefineria, listaComponentes);


            List<RefineriasModels> maximoAlquitran = Maximo_Alquitran(listaRefineria, listaComponentes);
            Totales_Refinerias(listaRefineria, listaComponentes);
        }
        private List<ComponentesModels> Totales_Anuales(List<RefineriasModels> refinerias, List<ComponentesModels> componentes)
        {
            List<ComponentesModels> listaComponentes = new List<ComponentesModels>();
            RefineriasModels refi = new RefineriasModels()
            {
                Refineria = "Suma total",
                Extra = refinerias.Sum(x => x.Extra),
                Normal = refinerias.Sum(x => x.Normal),
                Super = refinerias.Sum(x => x.Super),
            };

            ComponentesModels compoAceiteFino = componentes.FirstOrDefault(x => x.Componente == "Aceite Finos");
            ComponentesModels compoAlquitran = componentes.FirstOrDefault(x => x.Componente == "Alquitrán");
            ComponentesModels compoGrasasResidual = componentes.FirstOrDefault(x => x.Componente == "Grasas Residuales");

            listaComponentes.AddRange(new List<ComponentesModels>()
            {
                new ComponentesModels()
                {
                    Componente = compoAceiteFino.Componente,
                    Normal = compoAceiteFino.Normal * refi.Normal,
                    Extra = compoAceiteFino.Extra * refi.Extra,
                    Super = compoAceiteFino.Super * refi.Super,
                },
                new ComponentesModels()
                {
                    Componente = compoAlquitran.Componente,
                    Normal = compoAlquitran.Normal * refi.Normal,
                    Extra = compoAlquitran.Extra * refi.Extra,
                    Super = compoAlquitran.Super * refi.Super,
                },
                new ComponentesModels()
                {
                    Componente = compoGrasasResidual.Componente,
                    Normal = compoGrasasResidual.Normal * refi.Normal,
                    Extra = compoGrasasResidual.Extra * refi.Extra,
                    Super = compoGrasasResidual.Super * refi.Super,
                }
            });

            return listaComponentes;
        }
        private List<RefineriasModels> Maximo_Alquitran(List<RefineriasModels> refinerias, List<ComponentesModels> componentes)
        {
            List<RefineriasModels> listaRefinerias = new List<RefineriasModels>();
            ComponentesModels compoAlquitran = componentes.FirstOrDefault(x => x.Componente == "Alquitrán");

            Console.WriteLine("");
            foreach (var item in refinerias)
            {
                int extra = item.Extra * compoAlquitran.Extra;
                int super = item.Super * compoAlquitran.Super;
                int normal = item.Normal * compoAlquitran.Normal;

                listaRefinerias.Add(new RefineriasModels()
                {
                    Extra = extra,
                    Super = super,
                    Normal = normal,
                    Refineria = item.Refineria
                });

                if (extra > super && extra > normal)
                    Console.WriteLine($" Refineria {item.Refineria} máximo alquitrán:  Extra: {extra}");


                if (super > extra && super > normal)
                    Console.WriteLine($" Refineria {item.Refineria} máximo alquitrán:  Super: {super}");

                if (normal > extra && normal > super)
                    Console.WriteLine($" Refineria {item.Refineria} máximo alquitrán:  Normal: {normal}");
            }
            return listaRefinerias;

        }
        private List<ComponentesRefineriasModels> Totales_Refinerias(List<RefineriasModels> refinerias, List<ComponentesModels> componentes)
        {
            List<ComponentesRefineriasModels> componentesRefinerias = new List<ComponentesRefineriasModels>();

            Console.WriteLine("");
            foreach (var item in refinerias)
            {
                Console.WriteLine($"Refineria: {item.Refineria}");

                foreach (var compo in componentes)
                {
                    Console.WriteLine($"Total Componente: {compo.Componente} - Normal: {compo.Normal * item.Normal} Super: {compo.Super * item.Super} Extra: {compo.Extra * item.Extra}");

                    ComponentesRefineriasModels refineriaModels = new ComponentesRefineriasModels()
                    {
                        Refineria = item.Refineria,
                        Componente = compo.Componente,
                        Normal = compo.Normal * item.Normal,
                        Super = compo.Super * item.Super,
                        Extra = compo.Extra * item.Extra,
                    };
                    componentesRefinerias.Add(refineriaModels);
                }
                Console.WriteLine("");
            }

            return componentesRefinerias;
        }

    }
}
