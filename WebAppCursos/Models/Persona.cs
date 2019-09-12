using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCursos.Models
{
    public class Persona
    {
        public int ID { get; set; }
        public string Nombres { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = false)]
        [DataType(DataType.Date)]
        public DateTime FechaNacimiento { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string Telfono { get; set; }
        public string Direccion { get; set; }
        public Boolean Estado { get; set; } = true;


    }
}
