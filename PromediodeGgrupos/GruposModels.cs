using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromediodeGgrupos
{
    public class GruposModels
    {
        public GruposModels()
        {
            Estudiantes = new List<EstudiantesModels>();
        }
        public int IdGrupo { get; set; }
        public string Grupos { get; set; }

        public List< EstudiantesModels> Estudiantes { get; set; }
    }
}
