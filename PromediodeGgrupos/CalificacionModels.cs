using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromediodeGgrupos
{
    class CalificacionModels
    {
        public int IdCalificacion { get; set; }
        public int IdGrupo { get; set; }
        public int IdEstudiante { get; set; }
        public int IdMateria { get; set; }
        public double Nota { get; set; }
    }
}
