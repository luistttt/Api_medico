using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_medico.Models
{
    public class Medico
    {
        public string id_medico { get; set; }
        public string nombres { get; set; }
        public string telefono { get; set; }
        public string correo { get; set; }
        public DateTime fechaIngreso { get; set; }
    }
}