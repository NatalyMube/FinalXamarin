using System;
using System.Collections.Generic;
using System.Text;

namespace Salud.Models
{
    public class Paciente
    {

        public string nombre { get; set; }

        public string tipodeidentificacion { get; set; }

        public int identificacion { get; set; }

        public string eps { get; set; }

        public string tiposangre { get; set; }

        public string foto { get; set; }
    }
}
