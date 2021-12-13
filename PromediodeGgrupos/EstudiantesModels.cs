using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromediodeGgrupos
{
    public class EstudiantesModels
    { 
        public EstudiantesModels()
        {
            Materias = new List<MateriaModels>();
        }
        public int IdEstudiante { get; set; }
        public string Estudainte { get; set; }
        public int NotaGeneral { get; set; }
        public List<MateriaModels> Materias { get; set; }

    }
}
