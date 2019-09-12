using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCursos.Models
{
    public class Inscripcion
    {
        public int InscripcionID { get; set; }
        public int Grado { get; set; }
        public int CursoID { get; set; }
        public int EstudianteID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]

        public DateTime Fecha { get; set; }
        public Decimal Pago { get; set; }
        public Curso Curso { get; set; }

        public Estudiante Estudiante { get; set; }

    }
}
