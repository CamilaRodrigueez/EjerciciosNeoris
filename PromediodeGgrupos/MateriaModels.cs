using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromediodeGgrupos
{
    public class MateriaModels
    {
        public MateriaModels()
        {
            Calificaciones = new List<double>();
        }
        public int IdMateria { get; set; }
        public string Materia { get; set; }
        public double NotaGeneral { get; set; }
        public List<double> Calificaciones { get; set; }
    }
}
