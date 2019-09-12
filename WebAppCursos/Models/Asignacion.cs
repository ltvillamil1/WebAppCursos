    using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCursos.Models
{
    public class Asignacion
    {
        public int AsignacionID { get; set; }
        public int CursoID { get; set; }
        public int InstructorID { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }
        public Curso Curso { get; set; }
        public Instructor Instructor { get; set; }

    }
}
